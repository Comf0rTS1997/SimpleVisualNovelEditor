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

        private void Settings_Load(object sender, EventArgs e)
        {
            
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
