using System;
using System.Globalization;

namespace CurrencyFormatConverter
{
    class Program
    {
        static double firstNumber, secondNumber, thirdNumber;
        static double average, largest, smallest, total;
        static void Main(string[] args)
        {
            ConvertCurrency();
        }

        static void GetInputs()
        {
            Console.WriteLine("Please enter first amount ($):");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second amount ($):");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third amount ($):");
            thirdNumber = double.Parse(Console.ReadLine());
        }

        static void ConvertCurrency()
        {
            GetInputs();

            average = (firstNumber + secondNumber + thirdNumber) / 3;
            smallest = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            largest = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            total = firstNumber + secondNumber + thirdNumber;

            Print();
        }

        static void Print()
        {
            Console.WriteLine($"Average is: {average}");
            Console.WriteLine($"Smallest is: {smallest}");
            Console.WriteLine($"Largest is: {largest}");
            Console.WriteLine("Total is:");
            Console.WriteLine($"\tUS: {FormatCurrency(total, "en-US")}");
            Console.WriteLine($"\tSwedish: {FormatCurrency(total, "sv-SE")}");
            Console.WriteLine($"\tJapanese: {FormatCurrency(total, "ja-JP")}");
            Console.WriteLine($"\tThai: {FormatCurrency(total, "th-TH")}");
            Console.ReadKey();
        }

        static string FormatCurrency(double totalAmount, string cultureInfo)
        {
            return totalAmount.ToString("C", new CultureInfo(cultureInfo).NumberFormat);
        }
    }
}
