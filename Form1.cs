using System.Text;

namespace Sokrates_Cleanup_for_AD
{
    public partial class Form1 : Form
    {
        string LetzterExportPfad = null; // global speichern

        public Form1()
        {
            InitializeComponent();
        }

        private string ExtractSubstringsBySeparators(string input)
        {
            var separators = new List<char>();

            if (checkBoxDoppelnamen.Checked)
                separators.Add('-');

            if (checkBoxMehrereNamen.Checked)
                separators.Add(' ');

            var lines = input.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            var resultLines = new List<string>();

            foreach (var line in lines)
            {
                var fields = line.Split(';');
                var extractedFields = new List<string>();

                foreach (var field in fields)
                {
                    if (string.IsNullOrWhiteSpace(field))
                    {
                        extractedFields.Add("");
                        continue;
                    }

                    if (separators.Count == 0)
                    {
                        extractedFields.Add(field);
                        continue;
                    }

                    int firstIndex = field.Length;

                    foreach (var sep in separators)
                    {
                        int index = field.IndexOf(sep);
                        if (index != -1 && index < firstIndex)
                            firstIndex = index;
                    }

                    string extracted = firstIndex == field.Length ? field : field.Substring(0, firstIndex);
                    extractedFields.Add(extracted);
                }

                resultLines.Add(string.Join(";", extractedFields));
            }

            return string.Join(Environment.NewLine, resultLines);
        }

        private string CleanUmlauteDiakritika(string input)
        {
            var replacements = new Dictionary<string, string>
            {
                // Deutsche Umlaute
                { "Ä", "AE" }, { "ä", "ae" },
                { "Ö", "OE" }, { "ö", "oe" },
                { "Ü", "UE" }, { "ü", "ue" },
                { "ß", "ss" },

                // Slawische & weitere Zeichen
                { "Č", "C" }, { "č", "c" },
                { "Š", "S" }, { "š", "s" },
                { "Ž", "Z" }, { "ž", "z" },
                { "Ć", "C" }, { "ć", "c" },
                { "Đ", "D" }, { "đ", "d" },
                { "Ł", "L" }, { "ł", "l" },
                { "Ń", "N" }, { "ń", "n" },
                { "Ř", "R" }, { "ř", "r" },
                { "Ą", "A" }, { "ą", "a" },
                { "Ę", "E" }, { "ę", "e" },
                { "Ň", "N" }, { "ň", "n" },
                { "Ľ", "L" }, { "ľ", "l" },
                { "Ť", "T" }, { "ť", "t" },
                { "Ŕ", "R" }, { "ŕ", "r" },
                { "Ď", "D" }, { "ď", "d" },
                { "Ő", "O" }, { "ő", "o" },
                { "Ű", "U" }, { "ű", "u" },

                // Türkisch
                { "Ç", "C" }, { "ç", "c" },
                { "Ş", "S" }, { "ş", "s" },
                { "Ğ", "G" }, { "ğ", "g" },
                { "İ", "I" }, { "ı", "i" },

                // Rumänisch
                { "Ă", "A" }, { "ă", "a" },
                { "Â", "A" }, { "â", "a" },
                { "Î", "I" }, { "î", "i" },
                { "Ș", "S" }, { "ș", "s" },
                { "Ț", "T" }, { "ț", "t" },

                // Ergänzt: Í, í, Ó, ó
                { "Í", "I" }, { "í", "i" },
                { "Ó", "O" }, { "ó", "o" }
            };

            bool erstesVorkommenlassen = true;
            var builder = new StringBuilder(input.Length);

            foreach (char c in input)
            {
                if (c == 'ü')
                {
                    if (erstesVorkommenlassen)
                    {
                        builder.Append('ü'); // erstes ü bleibt erhalten
                        erstesVorkommenlassen = false;
                    }
                }
                else
                {
                    string key = c.ToString();
                    builder.Append(replacements.ContainsKey(key) ? replacements[key] : key);
                }

            }

            return builder.ToString();
        }

        // Tauscht die komplette 1. mit der 2. Spalte (durch ; getrennt) in jeder Zeile.
        // Zeilen mit weniger als 2 Spalten bleiben unverändert.
        private string TauscheKlasseSKZ(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var lines = input.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.Length == 0)
                    continue;

                var fields = line.Split(';'); // behält leere Felder bei (z.B. doppelte ;;)

                if (fields.Length >= 2)
                {
                    (fields[0], fields[1]) = (fields[1], fields[0]); // Swap
                    lines[i] = string.Join(";", fields);
                }
            }

            return string.Join(Environment.NewLine, lines);
        }

        private int ParseOutput()
        {
            string workingText = textBoxSource.Text;
            bool nichtszutun = true;

            if (checkBoxUmlauteDiakrit.Checked)
            {
                workingText = CleanUmlauteDiakritika(workingText);
                nichtszutun = false;
            }

            if (checkBoxDoppelnamen.Checked || checkBoxMehrereNamen.Checked)
            {
                workingText = ExtractSubstringsBySeparators(workingText);
                nichtszutun = false;
            }

            if (checkBoxTauschen.Checked)
            {
                workingText = TauscheKlasseSKZ(workingText);
                nichtszutun = false;
            }

            if (nichtszutun)
                workingText = textBoxSource.Text;

            textBoxCleaned.Text = workingText;
            return 0;
        }

        private void OeffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Konfiguration des OpenFileDialogs
            openFileDialog1.Title = "CSV-Datei öffnen";
            openFileDialog1.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            openFileDialog1.Multiselect = false;

            // Dialog anzeigen und prüfen, ob eine Datei ausgewählt wurde
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dateiinhalt lesen
                    string filecontent = File.ReadAllText(openFileDialog1.FileName);

                    // Inhalt in die TextBox schreiben
                    textBoxSource.Text = filecontent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Öffnen der Datei:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ParseOutput();
        }

        private void SpeicherunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Konfiguration des SaveFileDialogs
            saveFileDialog1.Title = "CSV-Datei speichern unter";
            saveFileDialog1.Filter = "CSV-Dateien (*.csv)|*.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.AddExtension = true;

            // Dialog anzeigen und prüfen, ob ein Speicherort gewählt wurde
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Inhalt aus der TextBox holen
                    string content = textBoxCleaned.Text;

                    // Inhalt in die gewählte Datei schreiben
                    File.WriteAllText(saveFileDialog1.FileName, content, Encoding.UTF8);

                    MessageBox.Show("Datei erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LetzterExportPfad = saveFileDialog1.FileName; // Pfad speichern
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Speichern:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = textBoxCleaned.Text;

            if (string.IsNullOrWhiteSpace(LetzterExportPfad))
            {
                // Kein Pfad vorhanden → "Speichern unter" auslösen
                SpeicherunterToolStripMenuItem_Click(sender, e);
                return;
            }

            try
            {
                File.WriteAllText(LetzterExportPfad, content, Encoding.UTF8);
                MessageBox.Show($"Datei erfolgreich gespeichert unter:\n{Path.GetFullPath(LetzterExportPfad)}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Schnellspeichern:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBoxAlle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlle.Checked)
            {
                checkBoxDoppelnamen.Checked = true;
                checkBoxMehrereNamen.Checked = true;
                checkBoxUmlauteDiakrit.Checked = true;
                checkBoxTauschen.Checked = true;
            }
            else
            {
                checkBoxDoppelnamen.Checked = false;
                checkBoxMehrereNamen.Checked = false;
                checkBoxUmlauteDiakrit.Checked = false;
                checkBoxTauschen.Checked = false;
            }
        }

        private void checkBoxMehrereNamen_CheckedChanged(object sender, EventArgs e)
        {
            ParseOutput();
        }

        private void checkBoxDoppelnamen_CheckedChanged(object sender, EventArgs e)
        {
            ParseOutput();
        }

        private void checkBoxUmlauteDiakrit_CheckedChanged(object sender, EventArgs e)
        {
            ParseOutput();
        }

        private void checkBoxTauschen_CheckedChanged(object sender, EventArgs e)
        {
            ParseOutput();
        }
    }
}
