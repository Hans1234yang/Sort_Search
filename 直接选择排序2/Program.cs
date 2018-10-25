using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接选择排序2
{
    class Program
    {
        //直接选择排序
        static void Main(string[] args)
        {
            int[] a = { 5,23,12,4,34};
            //临时值
            int b = 1;
            //n个数
            //进行n-1 轮排序
            for(int i =0; i<5-1; i++)
            {
                //
                int temp = i;
                for(int j=i+1; j<5; j++)       ///直接选择排序 每轮排序 只确定第一个。 所以每一轮的最后一个数的位置不变 
                {                                // 所以 每一路你的最后一个数都是a[n-1]
                    if(a[temp]>a[j])
                    {
                        temp = j;
                    }
                }
                ///这一轮排序后  最小的此时的temp 已经记下了最小的记号了。  a[temp] 最小。 此时a[i]是本次排序 第一个数
                //a[i] 和a[temp] 交换值
                b = a[i];
                a[i] = a[temp];
                a[temp] = b;
            }

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
