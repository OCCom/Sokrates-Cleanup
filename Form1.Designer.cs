namespace Sokrates_Cleanup_for_AD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            label1 = new Label();
            buttonSave = new Button();
            buttonOpen = new Button();
            checkBoxDiakritika = new CheckBox();
            checkBoxUmlaute = new CheckBox();
            checkBoxMehrereNamen = new CheckBox();
            checkBoxDoppelnamen = new CheckBox();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            oeffnenToolStripMenuItem = new ToolStripMenuItem();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            speicherunterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBoxSource = new TextBox();
            textBoxCleaned = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            checkBoxAlle = new CheckBox();
            panelMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(checkBoxAlle);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(buttonSave);
            panelMenu.Controls.Add(buttonOpen);
            panelMenu.Controls.Add(checkBoxDiakritika);
            panelMenu.Controls.Add(checkBoxUmlaute);
            panelMenu.Controls.Add(checkBoxMehrereNamen);
            panelMenu.Controls.Add(checkBoxDoppelnamen);
            panelMenu.Controls.Add(menuStrip1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1750, 111);
            panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(227, 38);
            label1.Name = "label1";
            label1.Size = new Size(307, 20);
            label1.TabIndex = 8;
            label1.Text = "Folgende Namensbestandteile bereinigen: ";
            // 
            // buttonSave
            // 
            buttonSave.BackgroundImage = (Image)resources.GetObject("buttonSave.BackgroundImage");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.Location = new Point(80, 31);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(62, 62);
            buttonSave.TabIndex = 7;
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            buttonOpen.BackgroundImage = (Image)resources.GetObject("buttonOpen.BackgroundImage");
            buttonOpen.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpen.Location = new Point(12, 31);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(62, 62);
            buttonOpen.TabIndex = 6;
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiakritika
            // 
            checkBoxDiakritika.AutoSize = true;
            checkBoxDiakritika.Location = new Point(614, 68);
            checkBoxDiakritika.Name = "checkBoxDiakritika";
            checkBoxDiakritika.Size = new Size(164, 24);
            checkBoxDiakritika.TabIndex = 5;
            checkBoxDiakritika.Text = "Diakritische Zeichen";
            checkBoxDiakritika.UseVisualStyleBackColor = true;
            // 
            // checkBoxUmlaute
            // 
            checkBoxUmlaute.AutoSize = true;
            checkBoxUmlaute.Location = new Point(521, 68);
            checkBoxUmlaute.Name = "checkBoxUmlaute";
            checkBoxUmlaute.Size = new Size(87, 24);
            checkBoxUmlaute.TabIndex = 4;
            checkBoxUmlaute.Text = "Umlaute";
            checkBoxUmlaute.UseVisualStyleBackColor = true;
            // 
            // checkBoxMehrereNamen
            // 
            checkBoxMehrereNamen.AutoSize = true;
            checkBoxMehrereNamen.Location = new Point(358, 68);
            checkBoxMehrereNamen.Name = "checkBoxMehrereNamen";
            checkBoxMehrereNamen.Size = new Size(157, 24);
            checkBoxMehrereNamen.TabIndex = 3;
            checkBoxMehrereNamen.Text = "Mehrere Vornamen";
            checkBoxMehrereNamen.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoppelnamen
            // 
            checkBoxDoppelnamen.AutoSize = true;
            checkBoxDoppelnamen.Location = new Point(226, 68);
            checkBoxDoppelnamen.Name = "checkBoxDoppelnamen";
            checkBoxDoppelnamen.Size = new Size(126, 24);
            checkBoxDoppelnamen.TabIndex = 2;
            checkBoxDoppelnamen.Text = "Doppelnamen";
            checkBoxDoppelnamen.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1750, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oeffnenToolStripMenuItem, speichernToolStripMenuItem, speicherunterToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(59, 24);
            dateiToolStripMenuItem.Text = "&Datei";
            // 
            // oeffnenToolStripMenuItem
            // 
            oeffnenToolStripMenuItem.Name = "oeffnenToolStripMenuItem";
            oeffnenToolStripMenuItem.Size = new Size(195, 26);
            oeffnenToolStripMenuItem.Text = "Ö&ffnen";
            oeffnenToolStripMenuItem.Click += oeffnenToolStripMenuItem_Click;
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            speichernToolStripMenuItem.Size = new Size(195, 26);
            speichernToolStripMenuItem.Text = "&Speichern";
            // 
            // speicherunterToolStripMenuItem
            // 
            speicherunterToolStripMenuItem.Name = "speicherunterToolStripMenuItem";
            speicherunterToolStripMenuItem.Size = new Size(195, 26);
            speicherunterToolStripMenuItem.Text = "Speichern &unter";
            speicherunterToolStripMenuItem.Click += speicherunterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(195, 26);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // textBoxSource
            // 
            textBoxSource.Dock = DockStyle.Left;
            textBoxSource.Location = new Point(0, 111);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.ReadOnly = true;
            textBoxSource.ScrollBars = ScrollBars.Vertical;
            textBoxSource.Size = new Size(884, 976);
            textBoxSource.TabIndex = 1;
            // 
            // textBoxCleaned
            // 
            textBoxCleaned.Dock = DockStyle.Fill;
            textBoxCleaned.Location = new Point(884, 111);
            textBoxCleaned.Multiline = true;
            textBoxCleaned.Name = "textBoxCleaned";
            textBoxCleaned.ReadOnly = true;
            textBoxCleaned.ScrollBars = ScrollBars.Vertical;
            textBoxCleaned.Size = new Size(866, 976);
            textBoxCleaned.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxAlle
            // 
            checkBoxAlle.AutoSize = true;
            checkBoxAlle.Location = new Point(784, 68);
            checkBoxAlle.Name = "checkBoxAlle";
            checkBoxAlle.Size = new Size(57, 24);
            checkBoxAlle.TabIndex = 9;
            checkBoxAlle.Text = "Alle";
            checkBoxAlle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1087);
            Controls.Add(textBoxCleaned);
            Controls.Add(textBoxSource);
            Controls.Add(panelMenu);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sokrates Export Cleaner";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem oeffnenToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem speicherunterToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBoxSource;
        private TextBox textBoxCleaned;
        private CheckBox checkBoxDiakritika;
        private CheckBox checkBoxUmlaute;
        private CheckBox checkBoxMehrereNamen;
        private CheckBox checkBoxDoppelnamen;
        private Button buttonOpen;
        private Button buttonSave;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBoxAlle;
    }
}
