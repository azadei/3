using System;
using System.Linq;



    class Program
    {
        static void Main(string[] args)
    {
        int[] numbers = { 9, 8, 6, 5 };

        var query = from num in numbers

                    select new { Number = num, sqrno = num * num};

        foreach (var result in query)

        {
            Console.WriteLine("result number = " + result.Number + " " + "result query = " + result.sqrno );

        }







    }
        
    }

