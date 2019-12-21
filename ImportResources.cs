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
        public String CharacterName;
        public String nickName;
        public ImportResources(String FileNameIn)
        {
            this.fileName = FileNameIn;
            InitializeComponent();
        }

        private void ImportResources_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.nickNameInput.Text != String.Empty)
            {
                this.nickName = nickNameInput.Text;

            }
            else
            {
                this.nickName = fileName;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
