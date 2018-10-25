using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 哈希查找
{
    class Program
    {
        //除法取余法
        static int hashLength = 13;

        //数据
        static int[] a = { 5, 4, 3, 2, 1 };

        //哈希表长度
        static int[] hash = new int[hashLength];
        static void Main(string[] args)
        {
            for (int i = 0; i < a.Length; i++)
            {
                InsertHash(hash, hashLength, a[i]);
            }
            //hash数据有
            Console.WriteLine("hash数据"+string.Join(",",hash));
        }

        //数据插入到hash表
        static void InsertHash(int[] hash, int hashLength, int data)
        {
            //哈希函数
            int hashAddress = data % 13;

            //如果key存在，说明已经被占用了，此时必须解决冲突

            while (hash[hashAddress] != 0)
            {
                hashAddress = (hashAddress + 1) % hashLength;
            }

            //将data存入字典中
            hash[hashAddress] = data;

        }
    }
}
