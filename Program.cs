using System;
namespace loops
{
    class Program

    {
        static void Main(string[]args)
        {


            Console.WriteLine("  ");
            Console.Write("please type here till which number you want numbers to be printed from 1 to N ----> ");

            int N = Convert.ToInt32 (Console.ReadLine());


        //  int A = 1;
        //    while (A<=N)
        //    {
        //         //int g = A+1 ;
        //     Console.WriteLine ($"{A}");
        //     A++ ;
        //    }




            // for ( int A = 0 ;  A<N ; A++ )
            // {
            //     int b = A+1 ;
            //     Console.WriteLine($"{b}");
            // }



            int A = 0;                  
            do
             {
                int g = A + 1 ;
                Console.WriteLine($"{g}");
                A++ ;
            }
            while (A<N);



            // Console.WriteLine("  ");
            // Console.Write("please type here till which number you want numbers to be printed from 1 to N ----> ");

            // int N = Convert.ToInt32 (Console.ReadLine());

            // int a = 0;
            // string[]numbers = {$"{a}"  , $"{a+1}" , $"{a+2}" } ;

            // foreach (var number in numbers)
            // {
            //     do
            //     {

            // Console.WriteLine($"{number+1}") ;
            // a++ ;
            // } while (a<N);
            // }
        }
    }
}