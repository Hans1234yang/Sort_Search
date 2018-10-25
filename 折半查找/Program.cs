using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 折半查找
{
    class Program
    {
        /// <summary>
        /// 折半查找
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};

            int result = Search(a, 4);

            if(result!=-1)
            {
                Console.WriteLine("存在的索引是{0}",result);
            }
            else
            {
                Console.WriteLine("不存在该数");
            }
            Console.ReadKey();
        }

        public static int Search(int[] b,int value)
        {
            //最前的索引
            int small = 0;

            //最后后的索引
            int big = b.Length-1;

            while(small<big)
            {
                int middle = (small+big) / 2;

                if(b[middle]==value)
                {
                    return middle;
                }
                else
                {
                    if (b[middle] > value)
                    {
                        big = middle - 1;
                    }

                    else
                    {
                        small = middle + 1;
                    }
                }           
            }
            return -1;
        }
    }
}
