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
        private SettingsManager Sett_man;
        public Settings(Form mainWindow, SettingsManager settMan)
        {
            InitializeComponent();
            this.mainWindowPointer = mainWindow;
            this.Sett_man = settMan;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Sett_man.settingRecorder.Size.ToString();
        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainWindowPointer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
