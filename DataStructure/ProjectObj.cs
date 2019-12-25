using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLinesEditor
{
    class ProjectObj
    {
        public String projName;
        public  List<String>  fileList;
        public String firstPlot;
        public Dictionary<String, String> resourceMap;

        public ProjectObj(String nameIn, List<String> fileDicIn, Dictionary<string, string> resourceMapIn)
        {
            this.projName = nameIn;
            this.fileList = fileDicIn;
            this.resourceMap = resourceMapIn;
        }


        public String returnJson()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
