using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace moeBot.app.config
{
    class ConfigReader
    {
        //Load File and send necessary info back to main thread
        public static void ConfigLoad()
        {
            //Get Path from Current Directory of Application
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //Seeking for Config Directory
            path = Path.Combine(path, "Config");


        }
    }
}