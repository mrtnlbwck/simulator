namespace symulator_procesora
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.krokButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.rejestry = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.AL = new System.Windows.Forms.TextBox();
            this.BH = new System.Windows.Forms.TextBox();
            this.BL = new System.Windows.Forms.TextBox();
            this.CL = new System.Windows.Forms.TextBox();
            this.DH = new System.Windows.Forms.TextBox();
            this.DL = new System.Windows.Forms.TextBox();
            this.CH = new System.Windows.Forms.TextBox();
            this.AH = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.ComboBox();
            this.rozkaz = new System.Windows.Forms.ComboBox();
            this.rejestr = new System.Windows.Forms.ComboBox();
            this.adresowanie = new System.Windows.Forms.ComboBox();
            this.wiersz = new System.Windows.Forms.TextBox();
            this.sztuczka = new System.Windows.Forms.TextBox();
            this.rejestry.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(62, 442);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(148, 52);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.praca_Click);
            // 
            // krokButton
            // 
            this.krokButton.Location = new System.Drawing.Point(216, 442);
            this.krokButton.Name = "krokButton";
            this.krokButton.Size = new System.Drawing.Size(148, 52);
            this.krokButton.TabIndex = 1;
            this.krokButton.Text = "KROK";
            this.krokButton.UseVisualStyleBackColor = true;
            this.krokButton.Click += new System.EventHandler(this.krokowa_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(370, 442);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 52);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(62, 506);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 52);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "ZAPISZ DO PLIKU";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(216, 506);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(148, 52);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "ODCZYTAJ Z PLIKU";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(370, 506);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(148, 52);
            this.endButton.TabIndex = 5;
            this.endButton.Text = "ZAKOŃCZ";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // rejestry
            // 
            this.rejestry.Controls.Add(this.textBox14);
            this.rejestry.Controls.Add(this.textBox13);
            this.rejestry.Controls.Add(this.textBox12);
            this.rejestry.Controls.Add(this.textBox11);
            this.rejestry.Controls.Add(this.textBox10);
            this.rejestry.Controls.Add(this.textBox9);
            this.rejestry.Controls.Add(this.AL);
            this.rejestry.Controls.Add(this.BH);
            this.rejestry.Controls.Add(this.BL);
            this.rejestry.Controls.Add(this.CL);
            this.rejestry.Controls.Add(this.DH);
            this.rejestry.Controls.Add(this.DL);
            this.rejestry.Controls.Add(this.CH);
            this.rejestry.Controls.Add(this.AH);
            this.rejestry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rejestry.Location = new System.Drawing.Point(142, 13);
            this.rejestry.Margin = new System.Windows.Forms.Padding(4);
            this.rejestry.Name = "rejestry";
            this.rejestry.Padding = new System.Windows.Forms.Padding(4);
            this.rejestry.Size = new System.Drawing.Size(302, 186);
            this.rejestry.TabIndex = 6;
            this.rejestry.TabStop = false;
            this.rejestry.Text = "REJESTRY";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(9, 87);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(35, 22);
            this.textBox14.TabIndex = 14;
            this.textBox14.Text = "BX";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(9, 119);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(35, 22);
            this.textBox13.TabIndex = 13;
            this.textBox13.Text = "CX";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(9, 151);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(35, 22);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "DX";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(9, 54);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(35, 22);
            this.textBox11.TabIndex = 11;
            this.textBox11.Text = "AX";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(177, 23);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(55, 22);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "L_bit";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(61, 25);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(55, 22);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "H_bit";
            // 
            // AL
            // 
            this.AL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AL.Location = new System.Drawing.Point(168, 55);
            this.AL.Margin = new System.Windows.Forms.Padding(4);
            this.AL.Name = "AL";
            this.AL.ReadOnly = true;
            this.AL.Size = new System.Drawing.Size(105, 22);
            this.AL.TabIndex = 8;
            // 
            // BH
            // 
            this.BH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BH.Location = new System.Drawing.Point(53, 87);
            this.BH.Margin = new System.Windows.Forms.Padding(4);
            this.BH.Name = "BH";
            this.BH.ReadOnly = true;
            this.BH.Size = new System.Drawing.Size(105, 22);
            this.BH.TabIndex = 7;
            // 
            // BL
            // 
            this.BL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BL.Location = new System.Drawing.Point(168, 87);
            this.BL.Margin = new System.Windows.Forms.Padding(4);
            this.BL.Name = "BL";
            this.BL.ReadOnly = true;
            this.BL.Size = new System.Drawing.Size(105, 22);
            this.BL.TabIndex = 6;
            // 
            // CL
            // 
            this.CL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CL.Location = new System.Drawing.Point(168, 119);
            this.CL.Margin = new System.Windows.Forms.Padding(4);
            this.CL.Name = "CL";
            this.CL.ReadOnly = true;
            this.CL.Size = new System.Drawing.Size(105, 22);
            this.CL.TabIndex = 5;
            // 
            // DH
            // 
            this.DH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DH.Location = new System.Drawing.Point(53, 151);
            this.DH.Margin = new System.Windows.Forms.Padding(4);
            this.DH.Name = "DH";
            this.DH.ReadOnly = true;
            this.DH.Size = new System.Drawing.Size(105, 22);
            this.DH.TabIndex = 4;
            // 
            // DL
            // 
            this.DL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DL.Location = new System.Drawing.Point(168, 151);
            this.DL.Margin = new System.Windows.Forms.Padding(4);
            this.DL.Name = "DL";
            this.DL.ReadOnly = true;
            this.DL.Size = new System.Drawing.Size(105, 22);
            this.DL.TabIndex = 3;
            // 
            // CH
            // 
            this.CH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CH.Location = new System.Drawing.Point(53, 119);
            this.CH.Margin = new System.Windows.Forms.Padding(4);
            this.CH.Name = "CH";
            this.CH.ReadOnly = true;
            this.CH.Size = new System.Drawing.Size(105, 22);
            this.CH.TabIndex = 2;
            // 
            // AH
            // 
            this.AH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AH.Location = new System.Drawing.Point(53, 55);
            this.AH.Margin = new System.Windows.Forms.Padding(4);
            this.AH.Name = "AH";
            this.AH.ReadOnly = true;
            this.AH.Size = new System.Drawing.Size(105, 22);
            this.AH.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(142, 370);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(108, 39);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.ok_Click);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(62, 321);
            this.wartosc.Margin = new System.Windows.Forms.Padding(4);
            this.wartosc.Multiline = true;
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(188, 41);
            this.wartosc.TabIndex = 14;
            // 
            // adres
            // 
            this.adres.FormattingEnabled = true;
            this.adres.Location = new System.Drawing.Point(62, 378);
            this.adres.Margin = new System.Windows.Forms.Padding(4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(72, 24);
            this.adres.TabIndex = 13;
            this.adres.SelectedIndexChanged += new System.EventHandler(this.adres_SelectedIndexChanged);
            // 
            // rozkaz
            // 
            this.rozkaz.AutoCompleteCustomSource.AddRange(new string[] {
            "MOV",
            "ADD",
            "SUB"});
            this.rozkaz.FormattingEnabled = true;
            this.rozkaz.Location = new System.Drawing.Point(62, 224);
            this.rozkaz.Margin = new System.Windows.Forms.Padding(4);
            this.rozkaz.Name = "rozkaz";
            this.rozkaz.Size = new System.Drawing.Size(188, 24);
            this.rozkaz.TabIndex = 12;
            this.rozkaz.Text = "Rozkaz";
            this.rozkaz.SelectedIndexChanged += new System.EventHandler(this.rozkaz_SelectedIndexChanged);
            // 
            // rejestr
            // 
            this.rejestr.FormattingEnabled = true;
            this.rejestr.Location = new System.Drawing.Point(62, 255);
            this.rejestr.Margin = new System.Windows.Forms.Padding(4);
            this.rejestr.Name = "rejestr";
            this.rejestr.Size = new System.Drawing.Size(188, 24);
            this.rejestr.TabIndex = 11;
            this.rejestr.Text = "Rejestr docelowy";
            this.rejestr.SelectedIndexChanged += new System.EventHandler(this.rejestr_SelectedIndexChanged);
            // 
            // adresowanie
            // 
            this.adresowanie.FormattingEnabled = true;
            this.adresowanie.Location = new System.Drawing.Point(62, 288);
            this.adresowanie.Margin = new System.Windows.Forms.Padding(4);
            this.adresowanie.Name = "adresowanie";
            this.adresowanie.Size = new System.Drawing.Size(188, 24);
            this.adresowanie.TabIndex = 10;
            this.adresowanie.Text = "Tryb adresowania";
            this.adresowanie.SelectedIndexChanged += new System.EventHandler(this.adresowanie_SelectedIndexChanged);
            // 
            // wiersz
            // 
            this.wiersz.Location = new System.Drawing.Point(304, 224);
            this.wiersz.Multiline = true;
            this.wiersz.Name = "wiersz";
            this.wiersz.Size = new System.Drawing.Size(214, 185);
            this.wiersz.TabIndex = 17;
            // 
            // sztuczka
            // 
            this.sztuczka.Enabled = false;
            this.sztuczka.Location = new System.Drawing.Point(552, 535);
            this.sztuczka.Name = "sztuczka";
            this.sztuczka.Size = new System.Drawing.Size(10, 22);
            this.sztuczka.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(587, 583);
            this.Controls.Add(this.sztuczka);
            this.Controls.Add(this.wiersz);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.rozkaz);
            this.Controls.Add(this.rejestr);
            this.Controls.Add(this.adresowanie);
            this.Controls.Add(this.rejestry);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.krokButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symulator procesora";
            this.rejestry.ResumeLayout(false);
            this.rejestry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button krokButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.GroupBox rejestry;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox AL;
        private System.Windows.Forms.TextBox BH;
        private System.Windows.Forms.TextBox BL;
        private System.Windows.Forms.TextBox CL;
        private System.Windows.Forms.TextBox DH;
        private System.Windows.Forms.TextBox DL;
        private System.Windows.Forms.TextBox CH;
        private System.Windows.Forms.TextBox AH;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox wartosc;
        private System.Windows.Forms.ComboBox adres;
        private System.Windows.Forms.ComboBox rozkaz;
        private System.Windows.Forms.ComboBox rejestr;
        private System.Windows.Forms.ComboBox adresowanie;
        private System.Windows.Forms.TextBox wiersz;
        private System.Windows.Forms.TextBox sztuczka;
    }
}

