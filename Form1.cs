namespace Sokrates_Cleanup_for_AD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oeffnenToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string dateiInhalt = File.ReadAllText(openFileDialog1.FileName);

                    // Inhalt in die TextBox schreiben
                    textBoxSource.Text = dateiInhalt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Öffnen der Datei:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void speicherunterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
