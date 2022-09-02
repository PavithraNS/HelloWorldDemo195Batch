using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch.CSharpBasicPrgms
{
    class ReverseWord
    {
        public static void ReadInput()
        {
            Console.WriteLine("Please provide some word to make reverse");
            string word=Console.ReadLine();
            FindReverse(word);
        }

        public static void FindReverse(string word)
        {
            string reverse = "";
            int n = 0;
            //kavitha
            char[] charArr=word.ToCharArray();
            n = charArr.Length;
            
            for (int i=n-1;i>=0;i--)
            {
                //Console.WriteLine(charArr[i]);
                reverse = reverse + charArr[i];
            }
            Console.WriteLine("After reverse:"+reverse);

            if(word.Equals(reverse))
                Console.WriteLine("Its palindrome");
            else
                Console.WriteLine("Its not a palindrome");
        }
    }
}
