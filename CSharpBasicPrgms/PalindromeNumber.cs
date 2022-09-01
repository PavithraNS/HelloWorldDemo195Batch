using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch.CSharpBasicPrgms
{
    class PalindromeNumber
    {
        public static void FindPolyndrome()
        {
            Console.WriteLine("Please enter number to find palindrome");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = ReverseNumber.Reverse(number);
            
            if (number == reverse)
            {
                Console.WriteLine("Given number is palindrome");
            }
            else
            {
                Console.WriteLine("Given number is not a palindrome");
            }
        }
    }
}
