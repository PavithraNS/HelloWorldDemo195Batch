using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch
{
    public class Dog
    {
        //characters or varibles
        public string name;
        public string color;
        public string breed;

        public void Walk()
        {
            Console.WriteLine("{0} can walk",name);
        }

        public void DogDetails()
        {
            Console.WriteLine("\nDogName:{0} Color:{1} Breed:{2}",name, color, breed);
        }
    }
}
