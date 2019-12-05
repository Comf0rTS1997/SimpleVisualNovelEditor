using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GameLinesEditor
{
    public partial class MainWindow : Form
    {
        private SettingsManager Sett_Man;
        private String filePath; // path of the file that is currently working on
        public MainWindow()
        {
            InitializeComponent();
            this.Sett_Man = new SettingsManager(Application.StartupPath);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Sett = new Settings(this,Sett_Man);
            Sett.Show();
            this.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }


        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Json Visual Novel Script(*.json) | *.json";
            openFileDialog1.FileName = String.Empty;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {
            resetEditorSize();
        }

        private void resetEditorSize()
        {
            groupBox1.Width = this.Width - groupBox2.Width;
            groupBox1.Location =new Point( groupBox2.Location.X + groupBox2.Size.Width, 0);
        }

       
    }
}
