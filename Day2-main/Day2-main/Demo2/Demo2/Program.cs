using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> 
/// program to reverse a string of alternate words in the given string
/// 
/// </summary>
namespace Demo2
{
    
    internal class Program
    {       
            static void Main()
            {
                string input = "welcome to dotnet programming";
                string[] words = input.Split(' ');
                //it will slipt the given sentence into words which are separated by spaces(' ') and the result is stored in the array

                for (int i = 0; i < words.Length; i++)
                {
                    if (i % 2 == 1)
                        words[i] = new string(words[i].Reverse().ToArray());
                }

                string result = string.Join(" ", words);
                Console.WriteLine(result);
            }

        }
    }

