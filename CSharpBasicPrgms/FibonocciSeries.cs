using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo195Batch.CSharpBasicPrgms
{
    public class FibonocciSeries
    {
        public static void FindSeries(int n)
        {
            int first = 0;
            int second = 1;
            int sum = 0;
            Console.Write("{0} {1}", first, second);
            
            for (int i = 2; i < n; i++)
            {
                sum = first + second;
                Console.Write(" {0}",sum);
                first = second;
                second = sum;
            }
        }
    }
}
