using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringOtherQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Frequency();
            Console.WriteLine();
            RemoveDuplicate();
            Console.WriteLine();
            PossibleSubstring();
            Console.WriteLine();
            Console.WriteLine(WordCount());
            //WordCount();
            Console.WriteLine();
            GetFirstCharacter();

        }


        public static void Frequency()
        {
            string s = "hellohello";

            Console.WriteLine(s);

            Console.WriteLine("Frequency");
            Dictionary<char, int> charcount = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if(c != ' ')
                {
                    if(!charcount.ContainsKey(c))
                    {
                        charcount.Add(c, 1);
                    }
                    else
                    {
                        charcount[c]++;
                    }
                }
            }

            foreach (var c in charcount)
            {
                Console.WriteLine("{0} - {1}" , c.Key, c.Value);
            }
        }


        public static void RemoveDuplicate()
        {
            string s = "hheelloo";

            Console.WriteLine(s);

            string result = string.Empty;

            for(int i = 0; i < s.Length; i++)
            {
                if (!result.Contains(s[i]))
                {
                    result += s[i];
                }
            }

            Console.WriteLine("After remove duplicate string");

            Console.WriteLine(result);
        }


        public static void PossibleSubstring()
        {
            string s = "abcd";

            Console.WriteLine(s);

            Console.WriteLine("Possible substring");

            for (int i = 0; i < s.Length; ++i)
            {
                StringBuilder sb = new StringBuilder(s.Length - i);

                for(int j = i; j < s.Length; j++)
                {
                    sb.Append(s[j]);
                    Console.WriteLine(sb + " ");
                }
            }
        }


        public static int WordCount()
        {
            string s = "hello wel come home";

            Console.WriteLine(s);

            Console.WriteLine("Total words in string");

            if (string.IsNullOrEmpty(s))
                return 0;

            s = s.Trim();

            var length = s.Split(' ').Length;

            return length;
        }


        public static void GetFirstCharacter()
        {
            string s = "hello wel come home";

            Console.WriteLine(s);

            Console.WriteLine("get first letter of word in uppercase");

            if (!string.IsNullOrEmpty(s))
            {
                string[] a = s.Split(' ');

                foreach(string item in a)
                {
                    Console.WriteLine(item.Substring(0, 1).ToUpper() + " ");
                }
            }
        }
    }
}
