using System;

namespace JeongKiYoung_ex3
{
    class MainApp
    {
                
        static void Main(string[] args)
        {

            int b = 0;

            while (true )
            {
                int a = 0;    // *을 그릴때 a값이 항상 0으로 초기화 되어야 한다.

                while (a <= b)  
                {
                    Console.Write("*");
                    a++;  //  0 부터 다시 그려
                          //  근데 b 는 넘을수 없어.
                    

                }
                Console.WriteLine();  // a 가 *그리는 작업을 끝냈으면 그다음에 줄바꿈 
                b++;  // *을 다 그리고 나서 b값 1 증가

                if (b == 5)
                    break;

            }
            
            int number1 = 5;

            while (true)
            {
                int a = 0;

                while (a < number1)
                {
                    Console.Write("*");
                    a++;


                }
                Console.WriteLine();
                number1--;

                if (number1 == 0)
                    break;

            }


            int number2 = 0;

            do
            {
                int a = 0;

                while (a < number2)
                {
                    Console.Write("*");
                    a++;


                }
                Console.WriteLine();
                number2++;

            }
            while (number2 <= 5);


            int number3 = 5;

            do
            {
                int a = 0;

                while (a < number3)
                {
                    Console.Write("*");
                    a++;


                }
                Console.WriteLine();
                number3--;

            }
            while (number3 >= 0);




            /*
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            while (arr.Length <= 3)
            {
                int b = arr.Length;
                Console.WriteLine($"{b}");
            }
            */

            // ------------------------------------------


            // int b = a +
            /*
            while (a < 1)
            {
                Console.Write("*");
                a += 1;
                Console.WriteLine("");

                
            }

            */




        }
    }
}
