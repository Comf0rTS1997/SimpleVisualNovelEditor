using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLinesEditor
{
    class projectReader
    {

        public static ProjectObj readProjectObjFromJson(String jsonInput)
        {
            ProjectObj result = JsonConvert.DeserializeObject<ProjectObj>(jsonInput);
            return result;
        }
    }
}
