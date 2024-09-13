using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_TestHarness
{
    class Palindrome
    {
        public string _RawPalindrome;
        public string _IsItPalindrome;
        public string _EditedPalindrome; 
    }
    class Program
    {
        static bool GetYesNo(string pPrompt)
        {
            Console.WriteLine(pPrompt);
            Console.WriteLine("Type Yes for yes and No for no.");
            string answer = Console.ReadLine();
            bool answerConfirmed = false;
            do
            {
                if (answer.ToLower() == "yes")
                {
                    answerConfirmed = true;
                    return true;
                }
                else if (answer.ToLower() == "no")
                {
                    answerConfirmed = true;
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid Answer.");
                    return GetYesNo(pPrompt);
                }
            } while (!answerConfirmed);
        }
        static string PalindromeTest(string pInput)
        {
            // Initialising variables
            string x;
            bool f;
            int a, z, g;
            x = pInput;
            g = x.Length;
            z = g - 1;
            a = 0;
            // Testing if palindromic
            if (g == 1)
            {
                f = true;
            }
            else
            {
                f = true;
                while (f && a < z)
                {
                    // Ignoring specified characters for palindrome testing
                    while (x.Substring(a, 1) == " " || x.Substring(a, 1) == "," || x.Substring(a, 1) == "!" || x.Substring(a, 1) == "?" || x.Substring(a, 1) == "." || x.Substring(a, 1) == ";")
                    {
                        a++;
                    }
                    while (x.Substring(z, 1) == " " || x.Substring(z, 1) == "," || x.Substring(z, 1) == "!" || x.Substring(z, 1) == "?" || x.Substring(z, 1) == "." || x.Substring(z, 1) == ";")
                    {
                        z--;
                    }
                    if (x.Substring(a, 1).ToUpper() == x.Substring(z, 1).ToUpper())
                    {
                        a++;
                        z--;
                    }
                    else
                    {
                        f = false;
                    }
                }
            }
            if (!f)
            {
                return "Not a Palindrome.";
            }
            else
            {
                return "Palindrome Found!.";
            }
        }


        static void Main(string[] args)
        {
            List<string> potentialPalindromes = new List<string>();

            Console.WriteLine("Please enter a test string?");
            do
            {
                potentialPalindromes.Add(Console.ReadLine());
            } while (GetYesNo("Would you like to add another test string?"));

            List<Palindrome> TestResults = new List<Palindrome>();
            int counter = 0;
            foreach (string str in potentialPalindromes)
            {
                Palindrome p = new Palindrome();
                TestResults.Add(p);
                string edited = str;
                edited = str.Replace("?", " ");
                edited = edited.Replace("!", " ");
                edited = edited.Replace(",", " ");
                edited = edited.Replace(";", " ");
                edited = edited.Replace(".", " ");
                edited = edited.Trim();
                TestResults[counter]._RawPalindrome = str;
                TestResults[counter]._EditedPalindrome = edited;
                TestResults[counter]._IsItPalindrome = (PalindromeTest(str));
                counter++;
            }

            foreach(Palindrome p in TestResults)
            {
                Console.WriteLine("Original string: {0}", p._RawPalindrome);
                Console.WriteLine("After removing symbols: {0}", p._EditedPalindrome);
                Console.WriteLine(p._IsItPalindrome);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
