using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moeInterface
{
    public interface IPlugin
    {
        string Name { get; }
        //Get the Plugin Name

        string shortID { get; }
        //Get the Plugin ID ( for command mode )

        string compatible_version { get; }
        //Get the compatible version for checking the compatibility

        string Hello();
        //Check the Function

        void Start();
        //Start for the plugin
    }
}
