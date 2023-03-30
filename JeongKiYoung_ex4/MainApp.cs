using System;

namespace JeongKiYoung_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("반복 횟수를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            // int c = number - 1;

            
            

            for (int a = 1; a <= number; a++)
            {
                for (int b = 1; b <= a; b++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();
                

            }
            return;

            if (number <= 0)
                goto BYE;
            BYE:
            Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");




        }
    }
}
