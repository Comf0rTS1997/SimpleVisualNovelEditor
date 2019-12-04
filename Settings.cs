using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLinesEditor
{
    public partial class Settings : Form
    {
        private Form mainWindowPointer;
        public Settings(Form mainWindow)
        {
            InitializeComponent();
            this.mainWindowPointer = mainWindow;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainWindowPointer.Enabled = true;
        }
    }
}
