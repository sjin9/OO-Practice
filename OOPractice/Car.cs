using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Car : Vehicle
    //encupsulation: private variables in public method
    {
        private Speaker speaker;
        private List<Chair> chairs = new (); //声明chair成员时直接new

        public Car() //: base("cool car", 30)
        {
        }

        public Car(string name, double speed) : base(name, speed) //inherit constructor from base
        {
            speaker = new Speaker();
        }

        public Car(IEngine engine) : base("cool car", engine.Speed()) //another constructor
        { // get 25/30 from IEngine engine, then get msg from "cool car", 25/30 from base
          // engine here 是对接口的类实现
        }

        public override string Branding()
        {
            return base.Branding() + "with 4 wheels"; //override based on the original method
        }
    }
}
