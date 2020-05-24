using System;
namespace ConvertNumberToSpeak
{
    public class ConvertNumToWords
    {

       static string[] one = {"", "one ", "two ", "three ", "four ",
                    "five ", "six ", "seven ", "eight ",
                    "nine ", "ten ", "eleven ", "twelve ",
                    "thirteen ", "fourteen ", "fifteen ",
                    "sixteen ", "seventeen ", "eighteen ",
                    "nineteen "};

       static string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                    "fifty ", "sixty ", "seventy ", "eighty ",
                    "ninety "};

       private string numToWords(int n, string s)
        {
            string str = "";

            if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
            {
                str += one[n];
            }

            if (n != 0)
            {
                str += s;
            }

            return str;
        }

        public string convertToWords(long n)
        {
      
            string out1 = "";

            try
            {
               
                out1 += numToWords((int)(n / 10000000),
                                            "crore ");
             
                out1 += numToWords((int)((n / 100000) % 100),
                                                    "lakh ");

                out1 += numToWords((int)((n / 1000) % 100),
                                            "thousand ");

                out1 += numToWords((int)((n / 100) % 10),
                                            "hundred ");

                if (n > 100 && n % 100 > 0)
                {
                    out1 += "and ";
                }

            
                out1 += numToWords((int)(n % 100), "");
            }
            
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            return out1;
        }

    }
}
