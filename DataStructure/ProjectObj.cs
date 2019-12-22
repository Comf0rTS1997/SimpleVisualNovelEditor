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
        public  List<String>  plotList;
        public String firstPlot;
        public Dictionary<String, Dictionary<String,String>> characterList; 

        public ProjectObj(String nameIn, List<String> plotListIn, Dictionary<String, Dictionary<String, String>> characterListIn)
        {
            this.projName = nameIn;
            this.plotList = plotListIn;
            this.characterList = characterListIn;
        }


        public String returnJson()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
