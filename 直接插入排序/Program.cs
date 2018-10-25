using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接插入排序
{
    class Program
    {
        //直接插入排序
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};
            int temp = 0;  //临时变量，存储待排序的数值 
            for (int i = 0; i <5; i++)
            {
                temp = a[i];          //待加入排序的数
                int index = i - 1;    //前面 的有序数组的 末尾位置

                //当有序数组的某个数大于 待排序的值时
                while (index >= 0 && a[index] > temp)
                {
                    a[index + 1] = a[index];   //如果有序 数组 存在一个值，比temp大，那么这个值往后移一
                    index = index - 1;   //     //有序数组末尾 值往前移一位 
                }
                a[index + 1] = temp;               
            }      
            
            //遍历输出数组
            for(int i=0; i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }     
    }
}
