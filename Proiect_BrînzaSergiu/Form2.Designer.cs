namespace Proiect_BrînzaSergiu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAcademic = new System.Windows.Forms.RadioButton();
            this.rbClasic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNastere = new System.Windows.Forms.DateTimePicker();
            this.tbRepetare = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUni = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbTitlu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(193, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare cititor nou!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilizator clasic sau academic?";
            // 
            // rbAcademic
            // 
            this.rbAcademic.AutoSize = true;
            this.rbAcademic.Location = new System.Drawing.Point(27, 105);
            this.rbAcademic.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbAcademic.Name = "rbAcademic";
            this.rbAcademic.Size = new System.Drawing.Size(177, 36);
            this.rbAcademic.TabIndex = 1;
            this.rbAcademic.TabStop = true;
            this.rbAcademic.Text = "Academic";
            this.rbAcademic.UseVisualStyleBackColor = true;
            this.rbAcademic.CheckedChanged += new System.EventHandler(this.rbAcademic_CheckedChanged);
            // 
            // rbClasic
            // 
            this.rbClasic.AutoSize = true;
            this.rbClasic.Location = new System.Drawing.Point(27, 50);
            this.rbClasic.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbClasic.Name = "rbClasic";
            this.rbClasic.Size = new System.Drawing.Size(130, 36);
            this.rbClasic.TabIndex = 0;
            this.rbClasic.TabStop = true;
            this.rbClasic.Text = "Clasic";
            this.rbClasic.UseVisualStyleBackColor = true;
            this.rbClasic.CheckedChanged += new System.EventHandler(this.rbClasic_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(909, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nume:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(1064, 143);
            this.tbNume.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(393, 38);
            this.tbNume.TabIndex = 4;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(1064, 205);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(393, 38);
            this.tbCNP.TabIndex = 6;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(931, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNP:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(1064, 267);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(393, 38);
            this.tbEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(909, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(1064, 329);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(393, 38);
            this.tbTelefon.TabIndex = 10;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(904, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nr. tel:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(1064, 391);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(393, 38);
            this.tbAdresa.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(885, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adresa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(796, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 38);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data naștere:";
            // 
            // dtNastere
            // 
            this.dtNastere.CustomFormat = "DD-MM-YYYY";
            this.dtNastere.Location = new System.Drawing.Point(1064, 455);
            this.dtNastere.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtNastere.Name = "dtNastere";
            this.dtNastere.Size = new System.Drawing.Size(393, 38);
            this.dtNastere.TabIndex = 13;
            this.dtNastere.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // tbRepetare
            // 
            this.tbRepetare.Location = new System.Drawing.Point(1064, 589);
            this.tbRepetare.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbRepetare.Name = "tbRepetare";
            this.tbRepetare.Size = new System.Drawing.Size(393, 38);
            this.tbRepetare.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(687, 589);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(338, 38);
            this.label15.TabIndex = 30;
            this.label15.Text = "Reintroduceți parola:";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(1064, 525);
            this.tbParola.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(393, 38);
            this.tbParola.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(896, 525);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 38);
            this.label16.TabIndex = 28;
            this.label16.Text = "Parola:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.Color.Black;
            this.btnInregistrare.ForeColor = System.Drawing.Color.Transparent;
            this.btnInregistrare.Location = new System.Drawing.Point(215, 571);
            this.btnInregistrare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(317, 60);
            this.btnInregistrare.TabIndex = 38;
            this.btnInregistrare.Text = "În&registrare";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbAcademic);
            this.groupBox2.Controls.Add(this.rbClasic);
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(215, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(317, 160);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(215, 667);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(317, 55);
            this.btnLogIn.TabIndex = 40;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbUni
            // 
            this.tbUni.Location = new System.Drawing.Point(1064, 658);
            this.tbUni.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbUni.Name = "tbUni";
            this.tbUni.Size = new System.Drawing.Size(393, 38);
            this.tbUni.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(791, 658);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(231, 38);
            this.label19.TabIndex = 41;
            this.label19.Text = "Universitatea:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(780, 727);
            this.label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(251, 38);
            this.label20.TabIndex = 43;
            this.label20.Text = "Titlu academic:";
            // 
            // cbTitlu
            // 
            this.cbTitlu.FormattingEnabled = true;
            this.cbTitlu.Items.AddRange(new object[] {
            "Licență",
            "Masterat",
            "Doctorat",
            "Lector universitar",
            "Conferenţiar universitar",
            "Profesor universitar"});
            this.cbTitlu.Location = new System.Drawing.Point(1064, 726);
            this.cbTitlu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbTitlu.Name = "cbTitlu";
            this.cbTitlu.Size = new System.Drawing.Size(397, 39);
            this.cbTitlu.TabIndex = 45;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1705, 912);
            this.Controls.Add(this.cbTitlu);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbUni);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.tbRepetare);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNastere);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimumSize = new System.Drawing.Size(1507, 753);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAcademic;
        private System.Windows.Forms.RadioButton rbClasic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNastere;
        private System.Windows.Forms.TextBox tbRepetare;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbUni;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbTitlu;
    }
}