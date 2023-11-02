using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOPractice;

namespace OOPracticeTest
{
    public class DriverTest
    {
        [Fact]
        public void Should_show_msg_when_drive_car()
        {
            Driver driver = new Driver();
            Car car = new Car("cool car", 30); //run empty constructor if (), run another one if given variable

            string msg = driver.Drive(car);

            Assert.Equal("cool car:speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_show_msg_when_drive_truck()
        {
            Driver driver = new Driver();
            Truck truck = new Truck(); //run empty constructor if (), run another one if given variable

            string msg = driver.Drive(truck);

            Assert.Equal("big truck:speed up 10 km/h", msg);
        }
    }
}
