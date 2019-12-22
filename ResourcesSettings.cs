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
    public partial class ResourcesSettings : Form
    {
        public Dictionary<String, Dictionary<String, String>> characterMap;
        public ResourcesSettings(Dictionary<String, Dictionary<String, String>> characterMapIn)
        {
            InitializeComponent();
            this.characterMap = characterMapIn;
        }

        private void ResourcesSettings_Load(object sender, EventArgs e)
        {
            String[] row = new string[4];
            row[0] = "Game";
            row[1] = "aaa";
            row[2] = "bbb";
            row[3] = "ccc";
            listView1.Items.Add(new ListViewItem(row));
        }
    }
}
