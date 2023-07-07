using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace quickpad
{
    public partial class about_window : Form
    {
        public about_window()
        {
            InitializeComponent();
        }

        private void about_forum_Load(object sender, EventArgs e)
        {
            // Get the version of the current assembly
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            // Set the form title
            this.Version.Text = "Version: " + version.ToString();
        }
    }
}
