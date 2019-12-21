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
   
    public partial class FirstPlot : Form
    {
        public String firstPlotNameInPropertyWindow;
        public List<String> plotList;
        public String currentFirstPlot;
        public FirstPlot(List<String> plotListIn, String CurrentPlotIn)
        {
            InitializeComponent();
            this.plotList = plotListIn;
            this.currentFirstPlot = CurrentPlotIn;
        }

        private void ProjectPropertySetting_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = currentFirstPlot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plotList.Contains(this.textBox1.Text))
            {
                this.firstPlotNameInPropertyWindow = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Plot does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ProjectPropertySetting_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    button1_Click(sender, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            } 
        }
    }
}
