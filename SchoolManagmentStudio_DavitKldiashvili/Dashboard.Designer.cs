
namespace SchoolManagmentStudio_DavitKldiashvili
{
    partial class Dashboard
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
            this.NavbarPanel = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Slidebar = new System.Windows.Forms.Panel();
            this.DavitKldiashvili = new System.Windows.Forms.Label();
            this.NavbarPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarPanel
            // 
            this.NavbarPanel.BackColor = System.Drawing.Color.Lime;
            this.NavbarPanel.Controls.Add(this.DavitKldiashvili);
            this.NavbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarPanel.Location = new System.Drawing.Point(0, 0);
            this.NavbarPanel.Name = "NavbarPanel";
            this.NavbarPanel.Size = new System.Drawing.Size(1268, 75);
            this.NavbarPanel.TabIndex = 0;
            this.NavbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(400, 478);
            this.Content.TabIndex = 1;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Content);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 478);
            this.panel3.TabIndex = 2;
            // 
            // Slidebar
            // 
            this.Slidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slidebar.Location = new System.Drawing.Point(400, 75);
            this.Slidebar.Name = "Slidebar";
            this.Slidebar.Size = new System.Drawing.Size(868, 478);
            this.Slidebar.TabIndex = 3;
            // 
            // DavitKldiashvili
            // 
            this.DavitKldiashvili.AutoSize = true;
            this.DavitKldiashvili.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DavitKldiashvili.ForeColor = System.Drawing.SystemColors.Control;
            this.DavitKldiashvili.Location = new System.Drawing.Point(108, 9);
            this.DavitKldiashvili.Name = "DavitKldiashvili";
            this.DavitKldiashvili.Size = new System.Drawing.Size(251, 47);
            this.DavitKldiashvili.TabIndex = 0;
            this.DavitKldiashvili.Text = "DavitKldiashvili";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 553);
            this.ControlBox = false;
            this.Controls.Add(this.Slidebar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NavbarPanel);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.NavbarPanel.ResumeLayout(false);
            this.NavbarPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavbarPanel;
        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel Slidebar;
        private MaterialSkin.Controls.MaterialLabel DavitKldiashvili_Project;
        private System.Windows.Forms.Label DavitKldiashvili;
    }
}

