using System;

namespace JeongKiYoung_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {

            for (int i = 5; 1 <= i; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            Console.Write("정수를 입력하세요 : ");


            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);


            for (int a = number1; 1 <= a; a--)
            {
                for (int b = 1; b <= a; b++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();

            }




        }
    }
}
