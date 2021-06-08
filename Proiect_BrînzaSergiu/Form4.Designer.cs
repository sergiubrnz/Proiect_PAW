namespace Proiect_BrînzaSergiu
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informațiiContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportăListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCarti = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_BrînzaSergiu.UserControl1();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(2350, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 74);
            this.button1.TabIndex = 15;
            this.button1.Text = "Împrumută cartea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRefresh.Location = new System.Drawing.Point(2350, 387);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(341, 74);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listă cărți disponibile:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informațiiContToolStripMenuItem,
            this.exportăListaToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2818, 49);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informațiiContToolStripMenuItem
            // 
            this.informațiiContToolStripMenuItem.Name = "informațiiContToolStripMenuItem";
            this.informațiiContToolStripMenuItem.Size = new System.Drawing.Size(236, 45);
            this.informațiiContToolStripMenuItem.Text = "Informații cont";
            this.informațiiContToolStripMenuItem.Click += new System.EventHandler(this.informațiiContToolStripMenuItem_Click);
            // 
            // exportăListaToolStripMenuItem
            // 
            this.exportăListaToolStripMenuItem.Name = "exportăListaToolStripMenuItem";
            this.exportăListaToolStripMenuItem.Size = new System.Drawing.Size(202, 45);
            this.exportăListaToolStripMenuItem.Text = "Exportă lista";
            this.exportăListaToolStripMenuItem.Click += new System.EventHandler(this.exportăListaToolStripMenuItem_Click);
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
            this.listViewCarti.Location = new System.Drawing.Point(44, 214);
            this.listViewCarti.Margin = new System.Windows.Forms.Padding(5);
            this.listViewCarti.MaximumSize = new System.Drawing.Size(2200, 810);
            this.listViewCarti.MinimumSize = new System.Drawing.Size(2200, 210);
            this.listViewCarti.MultiSelect = false;
            this.listViewCarti.Name = "listViewCarti";
            this.listViewCarti.ShowGroups = false;
            this.listViewCarti.Size = new System.Drawing.Size(2200, 810);
            this.listViewCarti.TabIndex = 17;
            this.listViewCarti.UseCompatibleStateImageBehavior = false;
            this.listViewCarti.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2350, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 72);
            this.button2.TabIndex = 18;
            this.button2.Text = "Întoarce carte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Location = new System.Drawing.Point(2282, 107);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(486, 150);
            this.userControl11.TabIndex = 19;
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(156, 48);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 45);
            this.toolStripMenuItem1.Text = " ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2818, 1077);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewCarti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informațiiContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportăListaToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCarti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private UserControl1 userControl11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}