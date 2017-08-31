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
                return "First Plugin";
            }
        }

        public string Do()
        {
            return "Do Something in First Plugin";
        }
    }
}
