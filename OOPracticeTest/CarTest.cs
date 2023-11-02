using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOPractice;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_SpeedUp_given_car()
        {
            //given
            Car car = new Car("cool car", 30); //构造方法，实例化class Car
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("cool car:speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_SpeedUp_given_truck()
        {
            //given
            Truck truck = new Truck(); //构造方法，实例化class Car
            //when
            string msg = truck.SpeedUp();
            //then
            Assert.Equal("big truck:speed up 10 km/h", msg);
        }

        [Fact]
        public void Should_return_engine_message_when_Speed_given_engine_for_car()
        {
            //given
            Car car = new Car(new ElectricEngine()); //构造方法，实例化class Car
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("cool car:speed up 25 km/h", msg);
        }
    }
}
