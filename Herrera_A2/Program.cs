using System;
using System.Globalization;

namespace Herrera_A2;
class Program
{
    static void Main(string[] args)
    {
        var today = DateTime.Now;
        var pi = Math.PI;
        CultureInfo usa = new CultureInfo("en-US");

        Console.WriteLine($"{today.ToString("MMMM dd, yyyy", usa),40}");
        //September 12, 2023 format (right alinged in a 40 character field)

        Console.WriteLine($"{today.ToString("yyyy.MM.dd", usa)}");
        //2023.09.12 format

        Console.WriteLine($"Day {today.Day} of {today.ToString("MMMM, yyyy")}");
        //Day 12 of September, 2023 format

        Console.WriteLine($"Year: {today.Year}, Month: {today.ToString("MM")}, Day: {today.Day}");
        //Year: 2023, Month: 09, Day: 12 format

        Console.WriteLine($"{today.DayOfWeek,10}");
        //Tuesday (right aligned in a 10 character field)

        Console.Write($"{today.ToString("t", usa),10}");
        Console.Write($"{today.DayOfWeek,10}\n");
        //2:54 PM Tuesday (right aligned in a 10 character field)

        Console.WriteLine($"h:{today.ToString("hh")}, m:{today.ToString("mm")}, s:{today.ToString("ss")}");
        //h:02 m:54 s:03, format

        Console.WriteLine($"{today.ToString("yyyy.MM.dd", usa)}.{today.ToString("hh.mm.ss")}");
        //2023.09.12.02.54.03 format

        Console.WriteLine(pi.ToString("C", usa));
        //Output Math.PI as currency

        Console.WriteLine($"{pi,10:0.###}");
        //Math.PI to three decimal places (right aligned in a 10 character field)

        Console.ReadLine();
    }
}
