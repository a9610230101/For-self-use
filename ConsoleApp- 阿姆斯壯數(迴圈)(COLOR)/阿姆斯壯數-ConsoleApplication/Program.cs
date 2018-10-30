using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阿姆斯壯數_ConsoleApplication
{
    //Project:阿姆斯壯數判別
    //Name:林紘毅(A107222011)
    //Date:2018.12.22


    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("阿姆斯壯數判別程式(A107222011 林紘毅)");
            while (true)
            {

            
            string num;
            double temp = 0;
            Console.WriteLine("請鍵入任意數字 : ");
            num = Console.ReadLine();
            char[] numArr = num.ToCharArray();

            for (int i = 0; i < num.Length; i++)
            {
                temp += Math.Pow(Convert.ToInt32(new string(numArr[i], 1)), num.Length);
            }
            Console.WriteLine(temp);
            if (temp == int.Parse(num))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("這是一個阿姆斯壯數!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            else
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("這並不是一個阿姆斯壯數.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }
    }
}
