using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moeInterface;

namespace moePlugin
{
    public class Plugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "moeBot Plugin";
            }
        }

        public string shortID
        {
            get
            {
                return "moePlugin";
            }
        }

        public string compatible_version
        {
            get
            {
                return "0.0.1";
            }
        }

        public string applicationPath(string path)
        {
            throw new NotImplementedException();
        }

        public string Hello()
        {
            return "Hello, " + Name + " has been loaded!";
        }

        public void Start()
        {
            
        }
    }
}
