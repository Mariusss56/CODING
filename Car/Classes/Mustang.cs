using Car.Interface;
namespace Car.Classes
{
    class Mustang : IVehicle
    {

        private String Name;


        public Mustang(string name)
        {
            this.Name = name;
        }
        public void Start()
        {    
              Console.WriteLine(this.Name + " is Starting");
        }
        public void Drive()
        {
            Console.WriteLine(this.Name + " is Driving");
        }
        public void Stop()
        {
            Console.WriteLine(this.Name + " is Stopping");
        }
    }
}