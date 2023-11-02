using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.classes
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string? Name { get; set; }
        private bool carIsDead;

        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSpeed, int currentSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            CurrentSpeed = currentSpeed;
        }


        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler? listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }

        public void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("***********************************\n");
        }

        public void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }   

        public void Run()
        {
            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine(new CarEngineHandler(OnCarEngineEvent));
            c1.RegisterWithCarEngine(new CarEngineHandler(OnCarEngineEvent2));
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
        }
    }
}
