using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_ACW
{
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
                    Console.WriteLine("");
                    return true;
                }
                else if (answer.ToLower() == "no")
                {
                    answerConfirmed = true;
                    Console.WriteLine("");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid Answer.");
                    Console.WriteLine("");
                    return GetYesNo(pPrompt);
                }
            } while (!answerConfirmed);
        }
        static string PalindromeTest(string pInput)
        {
            if (!string.IsNullOrWhiteSpace(pInput))
            {

                if (pInput.Any(char.IsLetterOrDigit))
                {
                    // Initialising variables
                    string x;
                    int a, z, g;
                    bool f;
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
                else
                {
                    Console.WriteLine("String must contain atleast one letter or digit.");
                    Console.WriteLine("Palindrom checker: Please a string");
                    return PalindromeTest(Console.ReadLine());
                }

            }
            else
            {
                Console.WriteLine("String must not be empty!");
                Console.WriteLine("Palindrom checker: Please a string");
                return PalindromeTest(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            do
            {
                do
                {
                    Console.WriteLine("Palindrom checker: Please enter a string");
                    Console.WriteLine(PalindromeTest(Console.ReadLine()));
                    Console.WriteLine("");
                } while (GetYesNo("Would you like to try another?"));
            } while (!GetYesNo("Would you like to Exit?")); 
        }
    }
}
