namespace pcMonitor
{
    partial class AboutDialog
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            versionLabel = new Label();
            projectLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.application;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(111, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 1;
            label1.Text = "Divoom PC Monitor";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(111, 34);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(48, 15);
            versionLabel.TabIndex = 2;
            versionLabel.Text = "Version ";
            // 
            // projectLinkLabel
            // 
            projectLinkLabel.AutoSize = true;
            projectLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            projectLinkLabel.Location = new Point(111, 57);
            projectLinkLabel.Name = "projectLinkLabel";
            projectLinkLabel.Size = new Size(89, 15);
            projectLinkLabel.TabIndex = 3;
            projectLinkLabel.TabStop = true;
            projectLinkLabel.Text = "Project Website";
            projectLinkLabel.LinkClicked += LinkLabel_LinkClicked;
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 97);
            Controls.Add(projectLinkLabel);
            Controls.Add(versionLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label versionLabel;
        private LinkLabel projectLinkLabel;
    }
}