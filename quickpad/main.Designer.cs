namespace quickpad
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            TextBox = new RichTextBox();
            Close = new Button();
            Save = new Button();
            Plus = new Button();
            Minus = new Button();
            Paste = new Button();
            Top_toggle = new Button();
            Copy = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox.Cursor = Cursors.IBeam;
            TextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(-2, 35);
            TextBox.Margin = new Padding(0);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(439, 393);
            TextBox.TabIndex = 0;
            TextBox.Text = "";
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.Location = new Point(370, 431);
            Close.Name = "Close";
            Close.Size = new Size(55, 23);
            Close.TabIndex = 1;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.Location = new Point(309, 431);
            Save.Name = "Save";
            Save.Size = new Size(55, 23);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Plus
            // 
            Plus.Location = new Point(105, 9);
            Plus.Name = "Plus";
            Plus.Size = new Size(91, 23);
            Plus.TabIndex = 3;
            Plus.Text = "Font +";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(12, 9);
            Minus.Name = "Minus";
            Minus.Size = new Size(87, 23);
            Minus.TabIndex = 4;
            Minus.Text = "Font -";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Paste
            // 
            Paste.Anchor = AnchorStyles.Bottom;
            Paste.BackColor = SystemColors.ControlLight;
            Paste.Location = new Point(123, 431);
            Paste.Name = "Paste";
            Paste.Size = new Size(180, 23);
            Paste.TabIndex = 5;
            Paste.Text = "Paste from clipboard";
            Paste.UseVisualStyleBackColor = false;
            Paste.Click += Paste_Click;
            // 
            // Top_toggle
            // 
            Top_toggle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Top_toggle.Location = new Point(272, 9);
            Top_toggle.Name = "Top_toggle";
            Top_toggle.Size = new Size(153, 23);
            Top_toggle.TabIndex = 6;
            Top_toggle.Text = "Untoggle window in front";
            Top_toggle.UseVisualStyleBackColor = true;
            Top_toggle.Click += Top_toggle_Click;
            // 
            // Copy
            // 
            Copy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Copy.Location = new Point(12, 431);
            Copy.Name = "Copy";
            Copy.Size = new Size(105, 23);
            Copy.TabIndex = 7;
            Copy.Text = "Copy text";
            Copy.UseVisualStyleBackColor = true;
            Copy.Click += Copy_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Plus;
            ClientSize = new Size(437, 457);
            Controls.Add(Copy);
            Controls.Add(Top_toggle);
            Controls.Add(Paste);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Save);
            Controls.Add(Close);
            Controls.Add(TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(453, 496);
            Name = "main";
            Text = "quickpad";
            TopMost = true;
            FormClosed += Form_Close_Click;
            Load += main_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TextBox;
        private Button Close;
        private Button Save;
        private Button Plus;
        private Button Minus;
        private Button Paste;
        private Button Top_toggle;
        private Button Copy;
    }
}