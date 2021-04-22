using System;

namespace งาน_4._1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            while(row < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                row = int.Parse(Console.ReadLine()); 
            }
            Pascal(row);
        }
        static void Pascal(int rows)
        {
            int  val = 1, i, j;
            Console.WriteLine("Pascal's triangle");
            for (i = 0; i <= rows; i++)
            {                
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j ;
                    Console.Write(val + " ");
                }
                Console.WriteLine();  
            }                         
                          
        }
    }
}
