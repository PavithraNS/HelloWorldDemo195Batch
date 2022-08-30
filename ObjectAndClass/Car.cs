using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch
{
    public class Car
    {
        //instance variables  or attributes
        //modelNumber,color,price
        public string color;
        public double price;
        public string model;

        //static variable
        public static string name;

        //methods
        //drive,start,stop
        public void Display()
        {
            //local varible
            string location = "Mumbai";
            string location1 = "Delhi";

            Console.WriteLine(color+" "+price+" "+model);
            Console.WriteLine("location:"+location);
        }      
    }
}
