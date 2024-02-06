using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upominac
{
    public class AppParameters
    {
        public string NazevParam { get; private set; } = "";
        public bool StavParam { get; private set; }

        
        public AppParameters(string nazevParam, bool stavParam)
        {
            NazevParam = nazevParam;
            StavParam = stavParam;
        }



    }
}
