
namespace Constructors
{
    class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    System.Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
