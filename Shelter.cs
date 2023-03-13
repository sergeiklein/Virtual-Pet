using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        private Dictionary<int, Pets> petSanctuary = new Dictionary<int, Pets>();

        public Dictionary<int, Pets> PetSanctuary { get { return petSanctuary; } }

       
        public void CreateNewPet()
        {
            Console.WriteLine("\n");
            Type("What New Pet Do You Want to Create?\nOrganic or Robotic?");
            string userChoice3 = Console.ReadLine().ToLower();
            if (userChoice3 == "organic")
            {
                OrganicPet orgPet = new OrganicPet();
                Console.WriteLine("\n");
                Type("What is the Species?");
                orgPet.Species = Console.ReadLine();
                Console.WriteLine("\n");
                Type("What's da wittle guy's name?");
                orgPet.Name = Console.ReadLine();
                AddNewPets(orgPet);
            }
            else if (userChoice3 == "robotic")
            {
                RoboticPet robPet = new RoboticPet();
                Console.WriteLine("\n");
                Type("What is the Brand?");
                Console.WriteLine("\n");
                robPet.Species = Console.ReadLine();
                Console.WriteLine("\n");
                Type("What's da wittle guy's name?");
                Console.WriteLine("\n");
                robPet.Name = Console.ReadLine();
                AddNewPets(robPet);
            }
            else
            {
                Console.Clear();
                Type("Please Select Organic or Robotic.");
                CreateNewPet();
            }
            Type("Your new Pet Has Been Created.");
            Console.WriteLine("\n");
        }
        public void AddNewPets(Pets pet)
        {
            PetSanctuary.Add(pet.IdNumber, pet);
            Console.WriteLine("\n");
        }

        public Pets FindPet(int idKey)
        {
            return PetSanctuary[idKey];
        }


        public void RemovePets()
        {
            Type("Which Pet Would You Like to Remove? (Type In Pet ID Number)\"");
            Pets ToRemove = null;//creating a placeholder for a pet
            int removeChoice = int.Parse(Console.ReadLine());
            ToRemove = FindPet(removeChoice);


            if (ToRemove is not null)
            {
                PetSanctuary.Remove(removeChoice);
                Type("The Pet " + ToRemove.Name + " ....Went to Live Happily on a Farm.");
                Console.WriteLine("\n");              
            }
            else
            {
                Type("Shelter Does Not Contain This Animal");
            }
        }


        public void PrintAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Print();
                
            }
        }
        public void FeedAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Feed();

            }
        }
        public void PlayAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Play();

            }
        }
        public void DoctorAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Doctor();

            }
        }
        
        public void TickAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Tick();
            }
        }

        public void Type(string text, int speed = 60)// Special method for Typing effect
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
        }

        //Method for music
        //public void Music(string[] args)//Specia method for Music player
        //{
        //    if (OperatingSystem.IsWindows())
        //    {
        //        SoundPlayer spookyPlayer = new SoundPlayer("TuneWav.wav");
        //        spookyPlayer.Load();
        //        spookyPlayer.Play();
        //        spookyPlayer.PlayLooping();
        //    }
        //}



    }


}
