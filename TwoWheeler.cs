using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
{
    internal class TwoWheeler : Vehicle
    {
        
        public TwoWheeler() { }

        public string GetBykBody()
        {
            return base.BodyType;
        }

        public string Wheeling(string wheelname)
        {
            return "";
        }

        public string Wheeling(int speed)
        {
            return "";
        }

        public string Wheeling(string wheelname, int speed)
        {
            return "";
        }

        public int Wheeling()
        {
            return 0;
        }

    }
}
