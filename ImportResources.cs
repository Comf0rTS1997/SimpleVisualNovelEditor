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
    public partial class ImportResources : Form
    {
        public String fileName;
        public String CharacterName = String.Empty;
        public String nickName;
        public ImportResources(String FileNameIn, String[] Characters)
        {
            InitializeComponent();
            foreach (String cha in Characters)
            {
                comboBox1.Items.Add(cha);
            }
            this.fileName = FileNameIn;
        }

        private void ImportResources_Load(object sender, EventArgs e)
        {
            this.fileNameLabel.Text = this.fileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.nickName = fileName;
            if (this.nickNameInput.Text != String.Empty)
            {
                this.nickName = nickNameInput.Text;
            }
            if (this.comboBox1.Text != String.Empty)
            {
                this.CharacterName = comboBox1.Text;
            }
            else
            {
                this.CharacterName = "Game";
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
