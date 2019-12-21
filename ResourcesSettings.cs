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
        public Dictionary<String, String> resourceMap;
        public ResourcesSettings(Dictionary<String, String> resourcesMapIn)
        {
            InitializeComponent();
            this.resourceMap = resourcesMapIn;
        }

        private void ResourcesSettings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
