using ConvertNumberToSpeak;
using System;
namespace ConsoleConvertNumberToSpell
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertNumToWords objNumToWords = new ConvertNumToWords();
            long longInput = long.Parse(Console.ReadLine());
            string output=objNumToWords.convertToWords(longInput);
            Console.WriteLine(output.ToString());
            Console.ReadLine();
        }
    }
}
