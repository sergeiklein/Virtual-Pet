using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class RoboticPet : Pets
    {
       
        public int Charge { get; set; }
        public int Fuel { get; set; }
        public int SleepMode { get; set; }
        

        public RoboticPet(string name, string brand, int charge, int fuel, int sleepMode)
        {
            Name = name;
            Species = brand;
            Charge = charge;
            Fuel = fuel;
            SleepMode = sleepMode;
            IdNumber = idNumber++;
            
        }
        public RoboticPet()
        {
            Name = "PetName";
            Species = "Species";
            Charge = 60;//same as health
            Fuel = 60;//same as hunger
            SleepMode = 60;//same as play
            IdNumber = idNumber;
        }

        public override void Feed()
        {
            Console.WriteLine("\n");
            Type("Your Robotic Pet Requires a Certain Fuel to Function Well. Choose Wisely: Gasoline OR Diesel?");
            Console.WriteLine("\n");
            string userChoice7 = Console.ReadLine().ToLower();
            Console.Clear();
            if (userChoice7 == "gasoline")
            {
                Type("Ooff....Their Gears Are Not Grinding Well....You Should Visit the Doctor.");
                Fuel = Fuel + 10;
            }
            else if (userChoice7 == "diesel")
            {
                Type("Yum! Your RoboPet Really Enjoyed the Fuel!\n");
                Fuel = Fuel - 10;
            }
            else
            {
                Type("Unrecognized Fuel, They Had to Sip On Old Oil From a Leftover Can They Found. They're full, but they hate you.");
                Fuel = Fuel - 10;
            }
            
            Console.WriteLine("\n");
            Type("The Fuel Level is Now = " + Fuel);
            
            ;
        }
      
        public override void Play()
        {
            Console.WriteLine("\n");
            SleepMode = SleepMode - 20;
            Fuel = Fuel + 10;
            Charge = Charge + 10;
            Type("Sleep Mode Level is now = " + SleepMode);
            Type("Fuel Level is now = " + Fuel);
            Type("Charge Level is now = " + Charge);
            Console.WriteLine("\n");
        }
       
        public override void Doctor()
        {
            Charge = Charge + 30;
            Console.WriteLine("\n");
            Type("Their Batteries Are in Mucho Better Condition.\n");
            Type("Your RoboPet is Feeling Charged Up! YEEEHAW\n");
            Console.WriteLine("\n");
            Type("Charge Level is now = " + Charge);
            Console.WriteLine("\n");
        }
        
        public override void Tick()
        {
            Fuel = Fuel + 5;
            SleepMode = SleepMode + 5;
            Charge = Charge - 5;
        }
        public override void Status()
        {
            Console.WriteLine("\n");
            Type("Welcome to the Status Screen. Here is the status of your RoboPet.");
            Console.WriteLine();
            Type("Charge Level is now = " + Charge);
            Type("Fuel Level is now = " + Fuel);
            Type("Sleep Mode Level is now = " + SleepMode);
            Console.WriteLine("\n");
        }

        public override void Print()
        {
            Console.WriteLine("\n");
            Type("Name: " + Name);
            Type("Brand: " + Species);
            Type("ID number: " + IdNumber);
            Type("Sleep Mode Level: " + SleepMode);
            Type("Charge Level: " + Charge);
            Type("Fuel Level: " + Fuel);
            Console.WriteLine("\n");
        }

        public void Type(string text, int speed = 60)// Special method for Typing effect
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
        }
    }


}

