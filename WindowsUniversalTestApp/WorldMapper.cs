using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsUniversalTestApp
{
    


    class WorldMapper
    {
        private int x { get; set; }
        private int y { get; set; }
        private int z { get; set; }
        private XmlDocument World;

        public void construct()
        {
            x = 1; y = 1; z = 0; // initial world location.
        }

        

    }
}
