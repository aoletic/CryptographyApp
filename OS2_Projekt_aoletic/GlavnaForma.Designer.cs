namespace OS2_Projekt_aoletic
{
    partial class GlavnaForma
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
            this.tboText = new System.Windows.Forms.TextBox();
            this.btn_savetext = new System.Windows.Forms.Button();
            this.gbo_Simetricno = new System.Windows.Forms.GroupBox();
            this.btn_SimetricnoDekriptiraj = new System.Windows.Forms.Button();
            this.btn_SimetricnoKriptiraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AsimetricoDekriptiraj = new System.Windows.Forms.Button();
            this.btn_AsimetricnoKriptiraj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_provjerapotpisa = new System.Windows.Forms.Button();
            this.btn_digitalnipotpis = new System.Windows.Forms.Button();
            this.btn_izracunajSazetak = new System.Windows.Forms.Button();
            this.btn_kreirajkljuceve = new System.Windows.Forms.Button();
            this.gbo_Simetricno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboText
            // 
            this.tboText.Location = new System.Drawing.Point(15, 12);
            this.tboText.Multiline = true;
            this.tboText.Name = "tboText";
            this.tboText.Size = new System.Drawing.Size(183, 167);
            this.tboText.TabIndex = 0;
            // 
            // btn_savetext
            // 
            this.btn_savetext.Location = new System.Drawing.Point(229, 12);
            this.btn_savetext.Name = "btn_savetext";
            this.btn_savetext.Size = new System.Drawing.Size(113, 47);
            this.btn_savetext.TabIndex = 1;
            this.btn_savetext.Text = "Spremi text";
            this.btn_savetext.UseVisualStyleBackColor = true;
            this.btn_savetext.Click += new System.EventHandler(this.btn_savetext_Click);
            // 
            // gbo_Simetricno
            // 
            this.gbo_Simetricno.BackColor = System.Drawing.Color.PowderBlue;
            this.gbo_Simetricno.Controls.Add(this.btn_SimetricnoDekriptiraj);
            this.gbo_Simetricno.Controls.Add(this.btn_SimetricnoKriptiraj);
            this.gbo_Simetricno.Location = new System.Drawing.Point(427, 12);
            this.gbo_Simetricno.Margin = new System.Windows.Forms.Padding(6);
            this.gbo_Simetricno.Name = "gbo_Simetricno";
            this.gbo_Simetricno.Size = new System.Drawing.Size(352, 166);
            this.gbo_Simetricno.TabIndex = 2;
            this.gbo_Simetricno.TabStop = false;
            this.gbo_Simetricno.Text = "Simetrično kriptiranje i dekriptiranje";
            // 
            // btn_SimetricnoDekriptiraj
            // 
            this.btn_SimetricnoDekriptiraj.Location = new System.Drawing.Point(203, 65);
            this.btn_SimetricnoDekriptiraj.Name = "btn_SimetricnoDekriptiraj";
            this.btn_SimetricnoDekriptiraj.Size = new System.Drawing.Size(112, 46);
            this.btn_SimetricnoDekriptiraj.TabIndex = 1;
            this.btn_SimetricnoDekriptiraj.Text = "Simetrično dekriptiraj";
            this.btn_SimetricnoDekriptiraj.UseVisualStyleBackColor = true;
            this.btn_SimetricnoDekriptiraj.Click += new System.EventHandler(this.btn_SimetricnoDekriptiraj_Click);
            // 
            // btn_SimetricnoKriptiraj
            // 
            this.btn_SimetricnoKriptiraj.Location = new System.Drawing.Point(39, 65);
            this.btn_SimetricnoKriptiraj.Name = "btn_SimetricnoKriptiraj";
            this.btn_SimetricnoKriptiraj.Size = new System.Drawing.Size(112, 46);
            this.btn_SimetricnoKriptiraj.TabIndex = 0;
            this.btn_SimetricnoKriptiraj.Text = "Simetrično kriptiraj";
            this.btn_SimetricnoKriptiraj.UseVisualStyleBackColor = true;
            this.btn_SimetricnoKriptiraj.Click += new System.EventHandler(this.btn_SimetricnoKriptiraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btn_AsimetricoDekriptiraj);
            this.groupBox1.Controls.Add(this.btn_AsimetricnoKriptiraj);
            this.groupBox1.Location = new System.Drawing.Point(427, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asimetrično kriptiranje i dekriptiranje";
            // 
            // btn_AsimetricoDekriptiraj
            // 
            this.btn_AsimetricoDekriptiraj.Location = new System.Drawing.Point(203, 65);
            this.btn_AsimetricoDekriptiraj.Name = "btn_AsimetricoDekriptiraj";
            this.btn_AsimetricoDekriptiraj.Size = new System.Drawing.Size(112, 46);
            this.btn_AsimetricoDekriptiraj.TabIndex = 1;
            this.btn_AsimetricoDekriptiraj.Text = "Asimetrično dekriptiraj";
            this.btn_AsimetricoDekriptiraj.UseVisualStyleBackColor = true;
            this.btn_AsimetricoDekriptiraj.Click += new System.EventHandler(this.btn_AsimetricoDekriptiraj_Click);
            // 
            // btn_AsimetricnoKriptiraj
            // 
            this.btn_AsimetricnoKriptiraj.Location = new System.Drawing.Point(39, 65);
            this.btn_AsimetricnoKriptiraj.Name = "btn_AsimetricnoKriptiraj";
            this.btn_AsimetricnoKriptiraj.Size = new System.Drawing.Size(112, 46);
            this.btn_AsimetricnoKriptiraj.TabIndex = 0;
            this.btn_AsimetricnoKriptiraj.Text = "Asimetrično kriptiraj";
            this.btn_AsimetricnoKriptiraj.UseVisualStyleBackColor = true;
            this.btn_AsimetricnoKriptiraj.Click += new System.EventHandler(this.btn_AsimetricnoKriptiraj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.btn_provjerapotpisa);
            this.groupBox2.Controls.Add(this.btn_digitalnipotpis);
            this.groupBox2.Controls.Add(this.btn_izracunajSazetak);
            this.groupBox2.Location = new System.Drawing.Point(15, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sažetak i digitalni potpis";
            // 
            // btn_provjerapotpisa
            // 
            this.btn_provjerapotpisa.Location = new System.Drawing.Point(179, 93);
            this.btn_provjerapotpisa.Name = "btn_provjerapotpisa";
            this.btn_provjerapotpisa.Size = new System.Drawing.Size(112, 46);
            this.btn_provjerapotpisa.TabIndex = 2;
            this.btn_provjerapotpisa.Text = "Provjeri digitalni potpis";
            this.btn_provjerapotpisa.UseVisualStyleBackColor = true;
            this.btn_provjerapotpisa.Click += new System.EventHandler(this.btn_provjerapotpisa_Click);
            // 
            // btn_digitalnipotpis
            // 
            this.btn_digitalnipotpis.Location = new System.Drawing.Point(42, 93);
            this.btn_digitalnipotpis.Name = "btn_digitalnipotpis";
            this.btn_digitalnipotpis.Size = new System.Drawing.Size(112, 46);
            this.btn_digitalnipotpis.TabIndex = 1;
            this.btn_digitalnipotpis.Text = "Potpiši datoteku";
            this.btn_digitalnipotpis.UseVisualStyleBackColor = true;
            this.btn_digitalnipotpis.Click += new System.EventHandler(this.btn_digitalnipotpis_Click);
            // 
            // btn_izracunajSazetak
            // 
            this.btn_izracunajSazetak.Location = new System.Drawing.Point(116, 30);
            this.btn_izracunajSazetak.Name = "btn_izracunajSazetak";
            this.btn_izracunajSazetak.Size = new System.Drawing.Size(112, 46);
            this.btn_izracunajSazetak.TabIndex = 0;
            this.btn_izracunajSazetak.Text = "Izračunaj sažetak";
            this.btn_izracunajSazetak.UseVisualStyleBackColor = true;
            this.btn_izracunajSazetak.Click += new System.EventHandler(this.btn_izracunajSazetak_Click);
            // 
            // btn_kreirajkljuceve
            // 
            this.btn_kreirajkljuceve.Location = new System.Drawing.Point(229, 131);
            this.btn_kreirajkljuceve.Name = "btn_kreirajkljuceve";
            this.btn_kreirajkljuceve.Size = new System.Drawing.Size(113, 47);
            this.btn_kreirajkljuceve.TabIndex = 5;
            this.btn_kreirajkljuceve.Text = "Kreiraj ključeve";
            this.btn_kreirajkljuceve.UseVisualStyleBackColor = true;
            this.btn_kreirajkljuceve.Click += new System.EventHandler(this.btn_kreirajkljuceve_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kreirajkljuceve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbo_Simetricno);
            this.Controls.Add(this.btn_savetext);
            this.Controls.Add(this.tboText);
            this.Name = "GlavnaForma";
            this.Text = "Glavna Forma";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.gbo_Simetricno.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboText;
        private System.Windows.Forms.Button btn_savetext;
        private System.Windows.Forms.GroupBox gbo_Simetricno;
        private System.Windows.Forms.Button btn_SimetricnoDekriptiraj;
        private System.Windows.Forms.Button btn_SimetricnoKriptiraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AsimetricoDekriptiraj;
        private System.Windows.Forms.Button btn_AsimetricnoKriptiraj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_digitalnipotpis;
        private System.Windows.Forms.Button btn_izracunajSazetak;
        private System.Windows.Forms.Button btn_provjerapotpisa;
        private System.Windows.Forms.Button btn_kreirajkljuceve;
    }
}

