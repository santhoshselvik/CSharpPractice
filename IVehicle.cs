using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
{
    internal interface IVehicle
    {
        int NoOfWheels { get; set; }
        short CalculateDistance(short distance);

        void VisualDrive();
    }
}
