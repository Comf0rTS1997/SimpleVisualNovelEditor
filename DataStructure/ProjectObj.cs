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

        public ProjectObj(String nameIn, List<String> fileDicIn)
        {
            this.projName = nameIn;
            this.fileList = fileDicIn;
        }


        public String returnJson()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
