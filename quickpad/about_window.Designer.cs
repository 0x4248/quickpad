namespace quickpad
{
    partial class about_window
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
            Title = new Label();
            Version = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(130, 37);
            Title.TabIndex = 0;
            Title.Text = "Quickpad";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Location = new Point(21, 57);
            Version.Name = "Version";
            Version.Size = new Size(45, 15);
            Version.TabIndex = 1;
            Version.Text = "Version";
            // 
            // about_forum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 114);
            Controls.Add(Version);
            Controls.Add(Title);
            Name = "about_forum";
            Text = "about_forum";
            Load += about_forum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Version;
    }
}