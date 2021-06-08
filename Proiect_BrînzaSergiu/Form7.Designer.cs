namespace Proiect_BrînzaSergiu
{
    partial class Form7
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
            this.listViewCarti = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.listViewCarti.Location = new System.Drawing.Point(23, 102);
            this.listViewCarti.Margin = new System.Windows.Forms.Padding(5);
            this.listViewCarti.MaximumSize = new System.Drawing.Size(800, 810);
            this.listViewCarti.MinimumSize = new System.Drawing.Size(800, 210);
            this.listViewCarti.MultiSelect = false;
            this.listViewCarti.Name = "listViewCarti";
            this.listViewCarti.ShowGroups = false;
            this.listViewCarti.Size = new System.Drawing.Size(800, 541);
            this.listViewCarti.TabIndex = 19;
            this.listViewCarti.UseCompatibleStateImageBehavior = false;
            this.listViewCarti.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Listă cărți împrumutate:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 83);
            this.button1.TabIndex = 20;
            this.button1.Text = "Întoarce cartea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(920, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 77);
            this.button2.TabIndex = 21;
            this.button2.Text = "Meniu principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1266, 705);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewCarti);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}