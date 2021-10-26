using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureProblem
{
    class AnagramDetection
    {
        public void Anagram(string s1, string s2)
        {

            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("They are anagrams ");
            }
            else
            {
                Console.WriteLine("They are not anagrams");
            }

        }
    }
}
    

