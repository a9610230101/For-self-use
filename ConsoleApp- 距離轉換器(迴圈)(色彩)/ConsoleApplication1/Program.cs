using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //作者:林紘毅 A107222011
    //日期:107/10/20
    //專案:距離轉換器(迴圈)

    class Program
    {
        static void Main(string[] args)
        {
            //標題
            Console.Title = "距離轉換器(迴圈)                                                                                                                                                                                            WRITE: A107222011 林紘毅";



            
            while (true)
            {

                
            System.Console.WriteLine("Cm轉Km.M請選1 ， Km轉Mile(英里)請選2");
                //前景顏色(文字顏色)
                Console.ForegroundColor = ConsoleColor.Blue;

                int S = Convert.ToInt32(System.Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;

           if (S == 1)
            {
                try
                {
                    Console.WriteLine("請輸入公分:");
                        //前景顏色(文字顏色)
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        int Cm = int.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.White;

                    if (Cm >= 100000)

                    {
                        Console.WriteLine(Cm.ToString() + "公分 = " + (Cm / 100000.0).ToString() + "公里");
                    }
                    else if (Cm >= 100)
                    {
                        Console.WriteLine(Cm.ToString() + "公分 = " + (Cm / 100.0).ToString() + "公尺");
                    }
                    else if (Cm > 0)
                    {
                        Console.WriteLine(Cm.ToString() + "公分 = " + Cm.ToString() + "公分");
                    }
                    else
                    {

                        Console.WriteLine("請輸入正整數");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

               
            }

            else if (S == 2)
            {
                try
                {
                    Console.WriteLine("請輸入公里:");

                        //前景顏色(文字顏色)
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        int km = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;

                    if (km >= 1)
                    {
                        Console.WriteLine(km.ToString() + "公里 = " + (km * 0.62137).ToString() + "英里");
                    }
                    else
                    {

                            Console.WriteLine("請輸入正整數");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

              

            }
            }
        }
    }
}
