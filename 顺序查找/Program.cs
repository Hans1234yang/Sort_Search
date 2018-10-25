using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };


            int result = SequenceSearch(a, 2);

            if(result!=-1)
            {
                Console.WriteLine("该值的索引是{0}",result);
            }
            else
            {
                Console.WriteLine("不存在该值");
            }

            Console.ReadKey();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bb">传入的数组</param>
        /// <param name="value">要查询的值</param>
        /// <returns></returns>
        public static int SequenceSearch(int[] b,int value)
        {
            for (int i = 0;i<b.Length;i++)
            {
                //返回索引
                if(b[i]==value)
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}
