using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Instrumentation
{
    class Program
    {
        static string PalindromeTest(string pInput)
        {
            // Initialising variables
            string x;
            bool f;
            int a, z, g;
            x = pInput;
            string y = x;
            g = x.Length;
            z = g - 1;
            a = 0;
            Console.WriteLine("Variables initialised. String: {0}", x);
            Console.WriteLine("Press any key to proceed.");
            Console.ReadKey();
            // Testing if palindromic
            if (g == 1)
            {
                f = true;
                Console.WriteLine("Input length is 1, therefore automatically a palindrome.");
                Console.WriteLine("Press any key to proceed.");
                Console.ReadKey();
                Console.WriteLine("");
            }
            else
            {
                f = true;
                while (f && a < z)
                {
                    // Ignoring specified characters for palindrome testing
                    while (x.Substring(a, 1) == " " || x.Substring(a, 1) == "," || x.Substring(a, 1) == "!" || x.Substring(a, 1) == "?" || x.Substring(a, 1) == "." || x.Substring(a, 1) == ";")
                    {
                        Console.WriteLine("Since x[{0}] = {1}  it must be ignored.", a, x[a]);
                        Console.WriteLine("Press any key to proceed.");
                        Console.ReadKey();
                        Console.WriteLine("");

                        a++;
                    }
                    while (x.Substring(z, 1) == " " || x.Substring(z, 1) == "," || x.Substring(z, 1) == "!" || x.Substring(z, 1) == "?" || x.Substring(z, 1) == "." || x.Substring(z, 1) == ";")
                    {
                        Console.WriteLine("Since x[{0}] = {1}  it must be ignored.", z, x[z]);
                        Console.WriteLine("Press any key to proceed.");
                        Console.ReadKey();
                        Console.WriteLine("");
                        z--;
                    }
                    if (x.Substring(a, 1).ToUpper() == x.Substring(z, 1).ToUpper())
                    {
                        Console.WriteLine("x[{0}] = {1}, x[{2}] = {3}", a, x[a], z, x[z]);
                        Console.WriteLine("Since x[a] == x[z]  it is so far palindromic.");
                        Console.WriteLine("Press any key to proceed.");
                        Console.ReadKey();
                        Console.WriteLine("");
                        a++;
                        z--;
                    }
                    else
                    {
                        Console.WriteLine("x[{0}] = {1}, x[{2}] = {3}", a, x[a], z, x[z]);
                        Console.WriteLine("Since x[a] != x[z], it is no longer a potential palindrome.");
                        Console.WriteLine("Press any key to proceed.");
                        Console.ReadKey();
                        Console.WriteLine("");
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
            Console.WriteLine("Please enter a string to check if palindromic.");
            Console.WriteLine(PalindromeTest(Console.ReadLine()));
            
            Console.ReadKey();
        }
    }
}
