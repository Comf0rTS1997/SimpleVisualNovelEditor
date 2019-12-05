using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameLinesEditor
{
    public class SettingsManager
    {
        private const String SETTINGFOLDER = "/Settings/";
        private const String SETTINGFILE = "/Settings.json";
        private String StartupPath;
        private String SettingFilePath;
        public settingObj settingRecorder;
        
        

        
        public SettingsManager(String path)
        {
            // read settings json file
            this.StartupPath = path;
            this.SettingFilePath = StartupPath + SETTINGFOLDER + SETTINGFILE;
            String jsonSett;
            try
            {
                jsonSett = System.IO.File.ReadAllText(SettingFilePath);
            }catch (Exception ex)
            {
                System.IO.Directory.CreateDirectory(this.StartupPath + SETTINGFOLDER);
                String defaultSetting = "{'Size': 20}";
                System.IO.File.WriteAllText(SettingFilePath,defaultSetting);
            }

            // Parse Json

            jsonSett = System.IO.File.ReadAllText(SettingFilePath);
            settingRecorder = JsonConvert.DeserializeObject<settingObj>(jsonSett);
            

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

    public class settingObj
    {
        public int Size;
    }
}
