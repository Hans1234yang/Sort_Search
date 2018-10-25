using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 希尔排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 8, 9, 1, 4 ,22,23,24,25};
            int temp = 0; //临时值
            int length = a.Length;

            //根据gap来分组，比如第一个gap 为5, 第二次gap为2， 第三组是 gap为1 
            for(int gap=length/2;gap>0; gap/=2)    //所以for循环一共就3次 ，5,2,1 
            {
                ///分了几组，就轮几次。 a[0],a[1],a[2],a[3],a[4] 
                for(int j=0;j<gap;j++)
                {
                    for(int k=j+gap;k<length;k=k+gap)   ///k是要排序的数
                    {
                        temp = a[k];   //a[5]是待排序的数，a[0]
                        int index = k - gap;  //index是 该组的有序数列的最后一个数

                        while(index>=0&&a[index]>temp)
                        {
                            a[index + gap] = a[index];  //移动该索引的数
                            index = index - gap;  //有序数组向前排序 
                        }
                        a[index + gap] = temp;   //把要保存的数，保存到index的下一个数
                    }

                }
            }

            for(int i=0;i<length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            

        }
    }
}
