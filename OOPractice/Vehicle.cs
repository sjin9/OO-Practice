namespace OOPractice
{
    public class Vehicle //encupsulation: private variables in public method
    {//alt+enter extract base
        private string name;
        private double speed;

        public Vehicle()
        {
        }

        public Vehicle(string name, double speed) //alt+enter generate constructor or get set
        {//constructor cannot be inherited, so wont be in child class
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}:speed up {speed} km/h";
        }

        public virtual string Branding()
        {
            return "I'm vehicle";
        }
    }
}