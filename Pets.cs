using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public abstract class Pets
    {
        public static int idNumber = 100;
        public string Name { get; set; }
        public string Species { get; set; }
        public int IdNumber { get; set; }

        
        
        public abstract void Feed();    
        public abstract void Play();
        public abstract void Doctor();
        public abstract void Print();
        public abstract void Tick();
        public abstract void Status();
    }
}
