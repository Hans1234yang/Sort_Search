using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            int[] a = { 3, 2, 1, 5, 4 };

            int low = 0;
            int high = a.Length - 1;
            QuickSort(a, low, high);
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }

        public static void QuickSort(int[] b,int _left,int _right)
        {
            int left = _left;
            int right = _right;
            int temp = 0;
          
            if(left<=right) //当坐标不相等时 
            {
                temp = b[left]; 
                while(left!=right)   //当 right 和left 指引不能 重合的时候，while循环
                {
                    while(right>left&&b[right]>temp)
                    {
                        right = right - 1;
                    }
                    b[left] = b[right];
                    while(left<right&&b[left]<temp)
                    {
                        left = left + 1;
                    }
                    b[right] = b[left];

                }

                /// 此时 right 和left 相重合  是相等的

                b[right] = temp;
                //基准值左边 递归
                QuickSort(b,_left,left-1);
                //基准值 右边 递归
                QuickSort(b,right+1,_right);
                
            }
        }

        
           
    }
}
