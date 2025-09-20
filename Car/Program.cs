using Car.Classes;
using Car.Interface;

namespace Car
{
    class Program
    {
        public static void Main(string[] args)
        {
            IVehicle[] vehicle = new IVehicle[3];
        

            vehicle[0] = new Mustang("Mustang");
            vehicle[1] = new Lamborghini("Lamborghini");
            vehicle[2] = new HondaCivic("Honda Civic");


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-----------------------");
                 vehicle[i].Start();
                 vehicle[i].Drive();
                vehicle[i].Stop();
           
}
           
        }
    }
}