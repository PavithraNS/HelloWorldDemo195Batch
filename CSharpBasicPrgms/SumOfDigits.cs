using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch.CSharpBasicPrgms
{
    class SumOfDigits
    {
        public static void FindSumOfDigits(int number)
        {
            int sum = 0,digit=0;
            while(number!=0) //4321
            {
                digit=number % 10;
                sum = sum+digit;
                number = number / 10;
            }
            Console.WriteLine("Sum of the given number:"+sum);
        }
    }
}
