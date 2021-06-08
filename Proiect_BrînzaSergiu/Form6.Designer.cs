namespace Proiect_BrînzaSergiu
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.listViewCarti = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_BrînzaSergiu.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCarti
            // 
            this.listViewCarti.AllowColumnReorder = true;
            this.listViewCarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCarti.FullRowSelect = true;
            this.listViewCarti.GridLines = true;
            this.listViewCarti.HideSelection = false;
            this.listViewCarti.Location = new System.Drawing.Point(28, 98);
            this.listViewCarti.Margin = new System.Windows.Forms.Padding(5);
            this.listViewCarti.MaximumSize = new System.Drawing.Size(2200, 810);
            this.listViewCarti.MinimumSize = new System.Drawing.Size(2200, 210);
            this.listViewCarti.MultiSelect = false;
            this.listViewCarti.Name = "listViewCarti";
            this.listViewCarti.ShowGroups = false;
            this.listViewCarti.Size = new System.Drawing.Size(2200, 810);
            this.listViewCarti.TabIndex = 3;
            this.listViewCarti.UseCompatibleStateImageBehavior = false;
            this.listViewCarti.View = System.Windows.Forms.View.Details;
            this.listViewCarti.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewCarti_ItemDrag);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2329, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Șterge cartea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2329, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modifică cantitatea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2329, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNr_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(2335, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 282);
            this.panel1.TabIndex = 7;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2329, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 87);
            this.button3.TabIndex = 8;
            this.button3.Text = "Adauga o carte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Location = new System.Drawing.Point(2236, 25);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(486, 150);
            this.userControl11.TabIndex = 9;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2725, 1049);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewCarti);
            this.Name = "Form6";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCarti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private UserControl1 userControl11;
    }
}