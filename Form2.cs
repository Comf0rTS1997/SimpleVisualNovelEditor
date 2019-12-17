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
    public partial class newPlot : Form
    {
        private Form mainFormPointer;
        public String plotName;
        public newPlot(Form mainForm)
        {
            InitializeComponent();
            this.mainFormPointer = mainForm;
        }

        private void newPlot_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFormPointer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apply();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                apply();
            }
        }

        private void apply()
        {
            this.plotName = textBox1.Text;
            if (this.plotName != String.Empty)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void newPlot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
