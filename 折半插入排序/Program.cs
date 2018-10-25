using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 折半插入排序
{
    /// <summary>
    /// 还不懂 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3,2,1,4,5};

            int smallerIndex = 0; //记录有序数组的起始位置
            int biggerIndex = 0; //记录有序数组的终止位置
            int midIndex = 0; //记录获取有序数组的中间位置（折半法的关键：折半的位置）
            int temp;  //记录待排的数值
            for (int i = 1; i < a.Length; i++)  //循环向有序数组中插入数值（i从1开始，因为操作的是同一个数组）
            {
                temp = a[i];   //记录待插入有序数组的数值
                biggerIndex = i - 1;
                //当smallerIndex==biggerIndex时，进入最后一次循环：smallerIndex指向大于temp的数组位置，biggerIndex指向小于temp的数组位置
                while (smallerIndex <= biggerIndex)
                {
                    midIndex = (smallerIndex + biggerIndex) / 2; //确定折半的位置
                    if (a[midIndex] >= temp)  //折半位置的数值 >= temp
                    {
                        biggerIndex = midIndex - 1;    //biggerIndex以midIndex为基础向前移动一位
                    }
                    else
                    {
                        smallerIndex = midIndex + 1;  //smallerIndex以midIndex为基础向后移动一位
                    }
                }
                for (int j = i - 1; j > biggerIndex; j--) //将有序数组中大于temp的数值分别向后移动一位
                {
                    a[j + 1] = a[j];  //
                }
                a[biggerIndex + 1] = temp;   //将temp插入biggerIndex + 1，因为此时array[biggerIndex]<temp<array[smallerIndex]
            }

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
