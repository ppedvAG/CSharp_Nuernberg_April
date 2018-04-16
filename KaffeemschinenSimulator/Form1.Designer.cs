namespace KaffeemschinenSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelBestellung = new System.Windows.Forms.Label();
            this.listboxKaffeemaschine = new System.Windows.Forms.ListBox();
            this.labelMaschinenBeschreibung = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxWassermenge = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelStörung = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxBohnen = new System.Windows.Forms.TextBox();
            this.timerStörung = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weiteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxMilch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBestellung
            // 
            this.labelBestellung.AutoSize = true;
            this.labelBestellung.BackColor = System.Drawing.Color.Transparent;
            this.labelBestellung.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestellung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBestellung.Location = new System.Drawing.Point(12, 71);
            this.labelBestellung.Name = "labelBestellung";
            this.labelBestellung.Size = new System.Drawing.Size(532, 59);
            this.labelBestellung.TabIndex = 0;
            this.labelBestellung.Text = "Bestellung: Espresso";
            // 
            // listboxKaffeemaschine
            // 
            this.listboxKaffeemaschine.FormattingEnabled = true;
            this.listboxKaffeemaschine.ItemHeight = 20;
            this.listboxKaffeemaschine.Location = new System.Drawing.Point(22, 283);
            this.listboxKaffeemaschine.Name = "listboxKaffeemaschine";
            this.listboxKaffeemaschine.Size = new System.Drawing.Size(136, 184);
            this.listboxKaffeemaschine.TabIndex = 1;
            this.listboxKaffeemaschine.SelectedIndexChanged += new System.EventHandler(this.listboxKaffeemaschine_SelectedIndexChanged);
            // 
            // labelMaschinenBeschreibung
            // 
            this.labelMaschinenBeschreibung.AutoSize = true;
            this.labelMaschinenBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaschinenBeschreibung.Location = new System.Drawing.Point(33, 30);
            this.labelMaschinenBeschreibung.Name = "labelMaschinenBeschreibung";
            this.labelMaschinenBeschreibung.Size = new System.Drawing.Size(0, 37);
            this.labelMaschinenBeschreibung.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wasser füllen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1Wasser_Click);
            // 
            // textBoxWassermenge
            // 
            this.textBoxWassermenge.Location = new System.Drawing.Point(202, 49);
            this.textBoxWassermenge.Name = "textBoxWassermenge";
            this.textBoxWassermenge.Size = new System.Drawing.Size(92, 35);
            this.textBoxWassermenge.TabIndex = 4;
            this.textBoxWassermenge.Text = "100";
            this.textBoxWassermenge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxWassermenge_KeyUp_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pad einlegen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelStörung
            // 
            this.labelStörung.AutoSize = true;
            this.labelStörung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStörung.ForeColor = System.Drawing.Color.Red;
            this.labelStörung.Location = new System.Drawing.Point(33, 50);
            this.labelStörung.Name = "labelStörung";
            this.labelStörung.Size = new System.Drawing.Size(196, 32);
            this.labelStörung.TabIndex = 7;
            this.labelStörung.Text = "Keine Störung";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Bohnen befüllen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4Bohnen_Click);
            // 
            // textBoxBohnen
            // 
            this.textBoxBohnen.Location = new System.Drawing.Point(202, 160);
            this.textBoxBohnen.Name = "textBoxBohnen";
            this.textBoxBohnen.Size = new System.Drawing.Size(92, 35);
            this.textBoxBohnen.TabIndex = 9;
            this.textBoxBohnen.Text = "100";
            // 
            // timerStörung
            // 
            this.timerStörung.Interval = 3000;
            this.timerStörung.Tick += new System.EventHandler(this.timerStörung_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(38, 43);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(143, 32);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "Kaffees: 0";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown.Location = new System.Drawing.Point(300, 43);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(183, 32);
            this.labelCountdown.TabIndex = 11;
            this.labelCountdown.Text = "10 Sekunden";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1033, 691);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 38);
            this.button5.TabIndex = 12;
            this.button5.Text = "Neues Fenster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(172, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 49);
            this.button6.TabIndex = 13;
            this.button6.Text = "Highscore";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.weiteresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // weiteresToolStripMenuItem
            // 
            this.weiteresToolStripMenuItem.Name = "weiteresToolStripMenuItem";
            this.weiteresToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.weiteresToolStripMenuItem.Text = "Weiteres";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 38);
            this.button7.TabIndex = 15;
            this.button7.Text = "Milch befüllen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7Milch_Click);
            // 
            // textBoxMilch
            // 
            this.textBoxMilch.Location = new System.Drawing.Point(202, 215);
            this.textBoxMilch.Name = "textBoxMilch";
            this.textBoxMilch.Size = new System.Drawing.Size(92, 35);
            this.textBoxMilch.TabIndex = 16;
            this.textBoxMilch.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.textBoxMilch);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBoxBohnen);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxWassermenge);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(843, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 355);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktionen";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.labelMaschinenBeschreibung);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(207, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 332);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beschreibung";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.labelStörung);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(207, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 176);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Strörungsmeldung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Maschine:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.labelCountdown);
            this.groupBox4.Controls.Add(this.labelScore);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(727, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 144);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1271, 796);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listboxKaffeemaschine);
            this.Controls.Add(this.labelBestellung);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KaffeSimulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBestellung;
        private System.Windows.Forms.ListBox listboxKaffeemaschine;
        private System.Windows.Forms.Label labelMaschinenBeschreibung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxWassermenge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelStörung;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxBohnen;
        private System.Windows.Forms.Timer timerStörung;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weiteresToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxMilch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

