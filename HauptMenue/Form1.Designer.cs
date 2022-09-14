namespace HauptMenue
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGelb = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.schriftartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStripMain.Size = new System.Drawing.Size(1086, 58);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.endeToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(111, 48);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(315, 54);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem1,
            this.projektToolStripMenuItem});
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(315, 54);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // dateiToolStripMenuItem1
            // 
            this.dateiToolStripMenuItem1.Name = "dateiToolStripMenuItem1";
            this.dateiToolStripMenuItem1.Size = new System.Drawing.Size(277, 54);
            this.dateiToolStripMenuItem1.Text = "Datei";
            // 
            // projektToolStripMenuItem
            // 
            this.projektToolStripMenuItem.Name = "projektToolStripMenuItem";
            this.projektToolStripMenuItem.Size = new System.Drawing.Size(277, 54);
            this.projektToolStripMenuItem.Text = "Projekt";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(315, 54);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(315, 54);
            this.endeToolStripMenuItem.Text = "Ende";
            this.endeToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(184, 48);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintergrundToolStripMenuItem,
            this.toolStripSeparator1,
            this.schriftartToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.fettToolStripMenuItem,
            this.kursivToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(139, 48);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // hintergrundToolStripMenuItem
            // 
            this.hintergrundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGelb,
            this.mnuBlau,
            this.mnuRot});
            this.hintergrundToolStripMenuItem.Name = "hintergrundToolStripMenuItem";
            this.hintergrundToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.hintergrundToolStripMenuItem.Text = "Hintergrund";
            // 
            // mnuGelb
            // 
            this.mnuGelb.Name = "mnuGelb";
            this.mnuGelb.Size = new System.Drawing.Size(448, 54);
            this.mnuGelb.Text = "Gelb";
            this.mnuGelb.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // mnuBlau
            // 
            this.mnuBlau.Name = "mnuBlau";
            this.mnuBlau.Size = new System.Drawing.Size(448, 54);
            this.mnuBlau.Text = "Blau";
            this.mnuBlau.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // mnuRot
            // 
            this.mnuRot.Name = "mnuRot";
            this.mnuRot.Size = new System.Drawing.Size(448, 54);
            this.mnuRot.Text = "Rot";
            this.mnuRot.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(445, 6);
            // 
            // schriftartToolStripMenuItem
            // 
            this.schriftartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArial});
            this.schriftartToolStripMenuItem.Name = "schriftartToolStripMenuItem";
            this.schriftartToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.schriftartToolStripMenuItem.Text = "Schriftart";
            // 
            // mnuArial
            // 
            this.mnuArial.Name = "mnuArial";
            this.mnuArial.Size = new System.Drawing.Size(448, 54);
            this.mnuArial.Text = "Arial Nova Light";
            this.mnuArial.Click += new System.EventHandler(this.menuItem_Clicked);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "8.25",
            "10",
            "13",
            "18"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 49);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(445, 6);
            // 
            // fettToolStripMenuItem
            // 
            this.fettToolStripMenuItem.Name = "fettToolStripMenuItem";
            this.fettToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.fettToolStripMenuItem.Text = "Fett";
            // 
            // kursivToolStripMenuItem
            // 
            this.kursivToolStripMenuItem.Name = "kursivToolStripMenuItem";
            this.kursivToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.kursivToolStripMenuItem.Text = "Kursiv";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 660);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(97, 41);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 710);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem dateiToolStripMenuItem1;
        private ToolStripMenuItem projektToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem endeToolStripMenuItem;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem ansichtToolStripMenuItem;
        private ToolStripMenuItem hintergrundToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem schriftartToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem fettToolStripMenuItem;
        private ToolStripMenuItem kursivToolStripMenuItem;
        private ToolStripMenuItem mnuGelb;
        private ToolStripMenuItem mnuBlau;
        private ToolStripMenuItem mnuRot;
        private ToolStripMenuItem mnuArial;
        private Label lblDisplay;
    }
}