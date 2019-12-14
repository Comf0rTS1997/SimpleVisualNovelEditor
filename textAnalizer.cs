using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameLinesEditor
{
    // used when saving file
    class textAnalizer
    {
        public static String ConvertToJson(SceneObj sceneObj)
        {
            String result = JsonConvert.SerializeObject(sceneObj, Formatting.Indented);
            return result;
        }
    }
}
