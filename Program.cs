using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fellowship");
            //maruti object
            Car maruti = new Car();
            Car.name = "Suzuki";
            Console.WriteLine("static variable:"+ Car.name);
            maruti.color = "red";
            maruti.price = 87732;
            maruti.model = "marutii";
            maruti.Display();
            //bmw object
            Car bmw = new Car();
            bmw.color = "white";
            bmw.price = 877328;
            bmw.model = "bmz";
            bmw.Display();
            Console.WriteLine("static variable:" + Car.name);

            Console.WriteLine("\nDog implementation");
            //Syntax for object creation of any class
            //className variable=new classname();
            Dog dog1 = new Dog();
            dog1.color = "brown";
            dog1.breed = "pugBreed";
            dog1.name = "pug";
            dog1.DogDetails();

            Dog dog2 = new Dog();
            dog2.color = "black";
            dog2.breed = "labb";
            dog2.name = "labrodar";
            dog2.DogDetails();
            //Dog dog3 = new Dog();
            Console.WriteLine("Making changes in remote master branch");
            Console.ReadLine();
        }
    }
}
