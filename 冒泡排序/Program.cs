using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    //冒泡排序
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 1;
            int[]a = {10,7,9,23,16 };
       
            for(int i=0;i<5-1;i++)
            {
                for(int j=0; j<5-1-i; j++)
                {
                    if(a[j]>a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                    ///冒泡排序，每次 都是决定了最后一个数。 所以每一轮的要比较的最后一个数的位置 都不同 
                }
            }

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
