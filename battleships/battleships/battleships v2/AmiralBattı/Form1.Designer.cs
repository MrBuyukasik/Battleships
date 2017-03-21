namespace AmiralBattı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BenPanel = new System.Windows.Forms.Panel();
            this.DusmanPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nasılOynanırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonRastgele = new System.Windows.Forms.Button();
            this.buttonHazir = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BenPanel
            // 
            this.BenPanel.Location = new System.Drawing.Point(12, 45);
            this.BenPanel.Name = "BenPanel";
            this.BenPanel.Size = new System.Drawing.Size(301, 301);
            this.BenPanel.TabIndex = 0;
            this.BenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BenPanel_Paint);
            this.BenPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BenPanel_MouseClick);
            this.BenPanel.MouseLeave += new System.EventHandler(this.BenPanel_MouseLeave);
            this.BenPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BenPanel_MouseMove);
            // 
            // DusmanPanel
            // 
            this.DusmanPanel.Location = new System.Drawing.Point(412, 45);
            this.DusmanPanel.Name = "DusmanPanel";
            this.DusmanPanel.Size = new System.Drawing.Size(301, 301);
            this.DusmanPanel.TabIndex = 1;
            this.DusmanPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DusmanPanel_Paint);
            this.DusmanPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DusmanPanel_MouseClick);
            this.DusmanPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DusmanPanel_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılOynanırToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nasılOynanırToolStripMenuItem
            // 
            this.nasılOynanırToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nasılOynanırToolStripMenuItem.Name = "nasılOynanırToolStripMenuItem";
            this.nasılOynanırToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nasılOynanırToolStripMenuItem.Text = "&Nasıl Oynanır?";
            this.nasılOynanırToolStripMenuItem.Click += new System.EventHandler(this.nasılOynanırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(319, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Denizaltı";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(319, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Muhrip";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(319, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Kruvazör";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(319, 114);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(87, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Amiral Gemisi";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(319, 259);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(87, 23);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Sıfırla";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonRastgele
            // 
            this.buttonRastgele.Location = new System.Drawing.Point(319, 288);
            this.buttonRastgele.Name = "buttonRastgele";
            this.buttonRastgele.Size = new System.Drawing.Size(87, 23);
            this.buttonRastgele.TabIndex = 5;
            this.buttonRastgele.Text = "Rastgele";
            this.buttonRastgele.UseVisualStyleBackColor = true;
            this.buttonRastgele.Click += new System.EventHandler(this.buttonRastgele_Click);
            // 
            // buttonHazir
            // 
            this.buttonHazir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHazir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHazir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHazir.Location = new System.Drawing.Point(319, 317);
            this.buttonHazir.Name = "buttonHazir";
            this.buttonHazir.Size = new System.Drawing.Size(87, 29);
            this.buttonHazir.TabIndex = 6;
            this.buttonHazir.Text = "Başla";
            this.buttonHazir.UseVisualStyleBackColor = false;
            this.buttonHazir.Click += new System.EventHandler(this.buttonHazir_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Crimson;
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRestart.Location = new System.Drawing.Point(319, 224);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(87, 29);
            this.buttonRestart.TabIndex = 9;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 13);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(412, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 13);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(12, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 13);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(412, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 13);
            this.panel4.TabIndex = 13;
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 374);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonHazir);
            this.Controls.Add(this.buttonRastgele);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.DusmanPanel);
            this.Controls.Add(this.BenPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(741, 413);
            this.Name = "Form1";
            this.Text = "Amiral Battı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BenPanel;
        private System.Windows.Forms.Panel DusmanPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nasılOynanırToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonRastgele;
        private System.Windows.Forms.Button buttonHazir;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

