using Car.Interface;
namespace Car.Classes
{
    class HondaCivic : IVehicle
    {

        private String Name;


        public HondaCivic(string name)
        {
            this.Name = name;
        }
        public void Start()
        {    
              Console.WriteLine(this.Name + " is Stopping");
        }
        public void Drive()
        {
            Console.WriteLine(this.Name + " is Driving");
        }
        public void Stop()
        {
            Console.WriteLine(this.Name + " is Starting");
        }
    }
}