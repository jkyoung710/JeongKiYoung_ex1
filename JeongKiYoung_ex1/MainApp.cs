using System;

namespace JeongKiYoung_ex1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            Console.Write("정수를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            

            for (int a = 1; a <= number; a++)
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
