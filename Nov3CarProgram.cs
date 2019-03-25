using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp_CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; }
        private bool carIsCrash;

        public Car() { MaxSpeed = 100; }
        public Car(int curSpd, int maxSpd, string name)
        {
            this.CurrentSpeed = curSpd;
            this.MaxSpeed = maxSpd;
            this.Name = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);         //Define the type of delegate.
        private CarEngineHandler listOfHandlers;                            //Define a member variable of the type of this delegata.
        public void RegistrWithCarEngine(CarEngineHandler methodToCall)     //Add registration function for calling code.
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate(int delta)                                   //Implement the Accelerate () method to access 
        {                                                                   //a list of delegate alls under the right conditions.
            if (carIsCrash)                                                 //If this car is crash, send messege.
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is Crash...");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)  //Car almost crash.
                    listOfHandlers("Careful buddy! Gonna blow!");
                if (CurrentSpeed >= MaxSpeed)
                    carIsCrash = true;
                else Console.WriteLine("Current Speed=" + CurrentSpeed);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(10, 100, "Regalia");
            car.RegistrWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            for (int i = 0; i < 6; i++)
            {
                car.Accelerate(20);
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }

        private static void OnCarEngineEvent(string msgForCaller)
        {
            Console.WriteLine("=> "+ msgForCaller);
        }
    }
}