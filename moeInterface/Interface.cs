using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moeInterface
{
    public interface IPlugin
    {
        string Name{ get; }
        string Do();
    }
}
