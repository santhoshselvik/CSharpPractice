using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
{
    public class Vehicle:IVehicle,IVehicleExtended
    {
        
       public int NoOfWheels {  get; set; }
        
       public string EngineType {  get; set; }

       private short MaxSpeed { get; set; }

        protected string BodyType {  get; set; }

        private readonly int EngineModel;

        public Vehicle() {
            EngineModel = 123;
        }
        public Vehicle(int EngineModel)
        {
          this.EngineModel = EngineModel;
        }

        void ManualDrive(short gear,bool applybreak)
        {
           
            if (applybreak==false) 
            { 
                //Drive with gear
            }
        }

        private void AutomaticDrive()
        {
            if (EngineType == "petrolengine")
            {
                //Automatic Drive
            }
        }


        internal void ShiftGear(short gear)
        {
           
            switch (gear)
            {
                case 1:
                    {

                        MaxSpeed = 20;
                        break;
                    }

                case 2:
                    {
                        MaxSpeed = 40;
                        break;
                    }

                case 3:
                    {
                        MaxSpeed = 60;
                        break;
                    }

                case 4:
                    {
                        MaxSpeed = 80;
                        break;
                    }

                case 5:
                    {
                        MaxSpeed = 100;
                        break;
                    }

                default:
                    {
                        MaxSpeed= 0;
                        break;
                    }
                    
            }
           

        }

        public short CalculateDistance(short distance)
        {
            if(distance>0 && MaxSpeed>0)
            {
                return (short)(distance / MaxSpeed);
            }
            return 0;
        }

        public void VisualDrive()
        {
            throw new NotImplementedException();
        }
    }
}
