using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Driver
    {
        public string Drive(Vehicle vehicle) //use vehicle instead of car/truck:多态，后期绑定，写的时候不知道对象是什么
        {
            return vehicle.SpeedUp();
        }
    }
}
