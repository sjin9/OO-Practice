namespace OOPractice
{
    public interface IEngine //define an interface
    {
        public int Speed(); //need to define speed() when add an engine in the interface
    }

    public class ElectricEngine : IEngine
    {
        public int Speed()
        {
            return 25;
        }
    }

    public class GasolineEngine : IEngine
    {
        public int Speed()
        {
            return 30;
        }
    }
}