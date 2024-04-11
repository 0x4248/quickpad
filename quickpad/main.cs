/* Quickpad
 * A simple text editor for editing text quickly.
 * Github: https://github.com/0x4248/quickpad
 * Licence: GNU General Public License v3.0
 * By: 0x4248
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace quickpad
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public static bool IsDarkThemeEnabled()
        {
            const string RegistryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string ValueName = "AppsUseLightTheme";

            object value = Registry.GetValue(RegistryKey, ValueName, null);

            if (value != null && int.TryParse(value.ToString(), out int themeValue))
            {
                return themeValue == 0;
            }

            // Default to light theme if the registry value is not found or not valid
            return false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string data = TextBox.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, data);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            TextBox.Text += clipboardText;

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            float currentSize = TextBox.Font.Size;
            TextBox.Font = new Font(TextBox.Font.FontFamily, currentSize + 1);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            float currentSize = TextBox.Font.Size;
            TextBox.Font = new Font(TextBox.Font.FontFamily, currentSize - 1);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string title = "quickpad - ";
            string text = TextBox.Text;
            if (text.Length > 10)
            {
                title += text.Substring(0, 10);
            }
            else
            {
                title += text;
            }
            this.Text = title;
        }

        private void main_Load(object sender, EventArgs e)
        {
            // If darktheme then make everything dark
            if (IsDarkThemeEnabled())
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                TextBox.BackColor = Color.FromArgb(30, 30, 30);
                TextBox.ForeColor = Color.White;
                Close.BackColor = Color.FromArgb(30, 30, 30);
                Close.ForeColor = Color.White;
                Save.BackColor = Color.FromArgb(30, 30, 30);
                Save.ForeColor = Color.White;
                Plus.BackColor = Color.FromArgb(30, 30, 30);
                Plus.ForeColor = Color.White;
                Minus.BackColor = Color.FromArgb(30, 30, 30);
                Minus.ForeColor = Color.White;
                Paste.BackColor = Color.FromArgb(30, 30, 30);
                Paste.ForeColor = Color.White;
                Copy.BackColor = Color.FromArgb(30, 30, 30);
                Copy.ForeColor = Color.White;
                Top_toggle.BackColor = Color.FromArgb(30, 30, 30);
                Top_toggle.ForeColor = Color.White;
                About.BackColor = Color.FromArgb(30, 30, 30);
                About.ForeColor = Color.White;
            }
            else
            {
                // Do nothing
            }
        }

        private void Form_Close_Click(object sender, FormClosedEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                MessageBox.Show("Nothing to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(TextBox.Text);
            }
        }

        private void Top_toggle_Click(object sender, EventArgs e)
        {
            // Turn off topmost
            if (this.TopMost == true)
            {
                this.TopMost = false;
                Top_toggle.Text = "Toggle window in front";
            }
            // Turn on topmost
            else
            {
                this.TopMost = true;
                Top_toggle.Text = "Untoggle window in front";
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            //open about_window.cs
            about_window about_window = new about_window();
            about_window.Show();

        }
    }
}
