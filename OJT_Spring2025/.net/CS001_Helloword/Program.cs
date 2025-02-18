using System;

namespace CS001_Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {   
            int a =0;
            int b =1;
            Console.WriteLine("Xin chao C#");
            a = Tong(a,b);
        }

        /// <summary>
        /// Phuong thuc tra ve tong cua 2 so nguyen
        /// </summary>
        /// <param name="a"> so nguyen 1</param>
        /// <param name="b"> so nguyen 2</param>
        /// <returns> tong a + b</returns> <summary>
        /// 
        /// </summary>
        /// <param name="a">so nguyen 1</param>
        /// <param name="b">so nguyen 2</param>
        /// <returns> tong cua a va b</returns>
        static int Tong (int a, int b){
            return a + b;
        }
    }

    class Abc
    {
        static void Xinchao()
        {
            Console.WriteLine("Xin chao den voi C#");
        }
    }
}