using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLinesEditor
{
    class SettingsManager
    {
        private const String SETTINGFOLDER = "Settings";
        private const String SETTINGFILE = "Settings.json";
        private String StartupPath;
        

        
        public SettingsManager(String path)
        {
            this.StartupPath = path;


        }

        public String getSettingValue(String setting_name)
        {
            String result = null;

            return result;
        }

        public void updateSetting(String setting_name, String setting_value)
        {

        }

    }
}
