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
   
    public partial class ProjectPropertySetting : Form
    {
        public String firstPlotNameInPropertyWindow;
        public ProjectPropertySetting()
        {
            InitializeComponent();
        }

        private void ProjectPropertySetting_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.firstPlotNameInPropertyWindow = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
