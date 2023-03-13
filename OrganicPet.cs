using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class OrganicPet : Pets
    {
            
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        

        public OrganicPet(string name, string species, int health, int hunger, int boredom)
        {
            Name = name;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
            IdNumber = idNumber++;
        }
        public OrganicPet()
        {
            Name = "PetName";
            Species = "Species";
            Health = 60;
            Hunger = 60;
            Boredom = 60;
            IdNumber = idNumber++;
        }
        public override void Feed()
        {
            Console.WriteLine(); //same as \n
            Type("What Do You Want to Give To Eat?");
            Type("Pizza or Brussel Sprouts? (Type One of the Options)");
            Console.WriteLine("\n");
            string userChoice5 = Console.ReadLine().ToLower();
            Console.Clear();
            if (userChoice5 == "pizza")
            {
                Type("They Enjoyed That Immensely!");
                

            }
            else if (userChoice5 == "brussel sprouts")
            {
                Type("They Have Been Fed....But They Did Not Enjoy the Food. Do Better.\n");
            }
            else
            {
                Type("Unrecognized food, they had to eat its own poop. They're full, but they hate you.");
            }
            Hunger = Hunger - 10;
            Console.WriteLine("\n");
            Type("Hunger Level is Now = " + Hunger);
            Console.WriteLine("\n");

        }
        public override void Play()
        {
            Console.WriteLine("\n");
            Type("What Do You Want To Do?");
            Type("Play Fetch or Go to Park? (Type Park OR Fetch)");
            Console.WriteLine("\n");
            string userChoice6 = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("\n");

            if (userChoice6 == "fetch")
            {
                Type("Wow! That was so fun!\n");
            }
            else if (userChoice6 == "park")
            {
                Type("They had fun with you and others!.\n");
            }
            else
            {
                Type("Ughhhhh, ughhhhhhh, okay... I guess they don't get to have any fun.\n");
            }
            
            Type( "They Are Very Grateful For Your Attention <3\n");
            Console.WriteLine("\n");
            Boredom = Boredom - 20;
            Hunger = Hunger + 10;
            Health = Health + 10;
            Type("Boredom Level is Now = " + Boredom);
            Type("Hunger Level is Now = " + Hunger);
            Type("Health Level is Now = " + Health);
            Console.WriteLine("\n");
        }
        public override void Doctor()
        {
            Console.WriteLine("\n");
            Type("You Just Gave Them a Health Tonic! It Wasn't Cheap, but...They're Feeling Much Better!");
            Health = Health + 30;
            Console.WriteLine(" \n");
            Type("Health Level is Now = " + Health);
            Console.WriteLine("\n");
        }
        public override void Tick()
        {
            Hunger = + 5; //same as below
            Boredom = Boredom + 5;
            Health = Health - 5;
        }
        public override void Status()
        {
            Console.WriteLine("\n");
            Type("Current Status:");
            Console.WriteLine("\n");
            Type("Health Level = " + Health);
            Type("Hunger Level = " + Hunger);
            Type("Boredom Level = " + Boredom);
            Console.WriteLine("\n");
        }
        public override void Print()
        {
            Console.WriteLine("\n");
            Type("Name: " + Name);
            Type("Species: " + Species);
            Type("ID number: " + IdNumber);
            Type("Boredom Level: " + Boredom);
            Type("Health Level: " + Health);
            Type("Hunger Level: " + Hunger);
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
