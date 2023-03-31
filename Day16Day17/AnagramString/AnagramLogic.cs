using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramString
{
    public class AnagramLogic
    {
        public static void checkAnagramString(string firstString,string secondString)
        {
            //compare lengths of 2 strings
            if (firstString.Length == secondString.Length)
            {
                //convert the strings into character arrays with lowercase
                char[] ch1 = (firstString.ToLower()).ToCharArray();
                char[] ch2 = (secondString.ToLower()).ToCharArray();

                //sort the arrays
                Array.Sort(ch1);
                Array.Sort(ch2);
                // convert the character arrays to strings
                String word1 = new String(ch1);
                string word2 = new String(ch2);
                // if two words are equal then 
                if (word1 == word2)
                {
                    Console.WriteLine("Strings {0}  and {1}  are Anagrams ", firstString, secondString);
                }
                else
                {
                    Console.WriteLine("Strings {0}  and {1}  are Not Anagrams ", firstString, secondString);
                }
            }
            else
            {//if 2 strings length are not equal
                Console.WriteLine("Strings {0}  and {1}  are Not Anagrams ", firstString, secondString);
            }
        }
    }
}
