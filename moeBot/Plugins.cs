using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Plugins
{
    class Plugin
    {
        // Let info.json Load in
        // Parse the info.json


        /********************************************************************
         * {
         *   "name": "Example Plugin",
         *   "id": "expl",
         *   "alternatedid": "explP",
         *   "version": "1.0.0",
         *   "compatible-version": "(1.0.0",
         *   "description": "This is A Example Plugin Created by Your Cat.",
         *   "contributors": ["Cat", "Neko"],
         *   "credits": ,
         *   "root": "./example",
         *   "config": "./example/config",
         *   "repository":
         *   {
         *     "type": "git",
         *     "url": "https://github.com/example/moeBot-plugin-example"
         *   },
         * }
         ********************************************************************/


        // name
        // id
        // 
    }
    class Loader
    {
        public static void Plugin()
        {

        }



        //Find Path
        
        private List<string> PathFinder()
        {
            List<string> pluginpath = new List<string>();
            try
            {
                //获取程序的基目录
                string path = AppDomain.CurrentDomain.BaseDirectory;
                //合并路径，指向插件所在目录。
                path = Path.Combine(path, "Plugins");
                foreach (string filename in Directory.GetFiles(path, "*.dll"))
                {
                    pluginpath.Add(filename);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return pluginpath;
        }

        //private 
    }

    class Initializer
    {
        public static void PreInitialization()
        {

        }
        public static void Initialization()
        {

        }
    }
}
 