using System;

namespace Proje3
{
    class Program
    {
        static void Main(string[] args)
        {
            //I defined some variables
            int counter = 0;
            int counter1 = 0;
            int x = 0;

            //I wanted the text as input from user
            Console.WriteLine("Please enter a text:\n");
            string str = Console.ReadLine();
            Console.WriteLine(" ");

            //I removed unwanted variables from the text and split it into parts
            str = str.Replace(",", " ");
            str = str.Replace(".", " ");
            str = str.Replace("/", " ");
            str = str.Replace("+", " ");
            str = str.Replace("?", " ");
            str = str.Replace(";", " ");
            str = str.Replace(":", " ");
            str = str.Replace('"', ' ');
            str = str.Replace("!", " ");
            str = str.Replace("#", " ");
            str = str.Replace("$", " ");
            str = str.Replace("%", " ");
            str = str.Replace("&", " ");
            str = str.Replace("'", " ");
            str = str.Replace("(", " ");
            str = str.Replace(")", " ");
            str = str.Replace("<", " ");
            str = str.Replace(">", " ");
            str = str.Replace("=", " ");
            str = str.Replace("@", " ");

            while (!str.Contains(" "))
                str = str.Replace("  ", " ");

            string[] words = str.Split(" ");

            //I wanted the pattern as input from user
            Console.WriteLine("Please enter a pattern:\n");
            string pattern0 = Console.ReadLine();
            string pattern = pattern0.ToLower();
            Console.ReadLine();

            //I selected the words in order using the for statement
            for (int i = 0; i < words.Length; i++)
            {
                //I queried whether the pattern and the word are the same length
                if (words[i].Length == pattern.Length)
                {
                    string str0 = words[i];
                    string str1 = str0.ToLower();


                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (pattern[j] == '-')
                        {
                            counter++;
                        }

                        else if (pattern[j] == '*')
                        {
                            counter++;
                        }

                        else if (pattern[j] == str1[j])
                        {
                            counter++;
                        }
                    }

                    if (counter == pattern.Length)
                    {
                        Console.WriteLine(str0);
                    }
                    counter = 0;
                }

                //I questioned the length of the word is longer than the pattern
                else if (words[i].Length > pattern.Length)
                {
                    string str3 = words[i];
                    string str2 = str3.ToLower();
                    x = str2.Length - pattern.Length;

                    for (int k = 0; k < pattern.Length; k++)
                    {

                        if (x <= pattern.Length)
                        {
                            for (int m = 0; m < str2.Length; m++)
                            {
                                if (m > x && pattern[0] == '*' && str2[m] == pattern[m - x])
                                {
                                    counter++;
                                }
                                else if (m + 1 <= pattern.Length && pattern[pattern.Length - 1] == '*' && str2[m] == pattern[m])
                                {
                                    counter1++;
                                }
                            }

                            if (pattern[0] == '*' && (counter != 0 || counter1 != 0))
                            {
                                if (counter + counter1 + x == str2.Length - 1)
                                {
                                    Console.WriteLine(str3);
                                }
                            }
                            if (pattern[pattern.Length - 1] == '*' && (counter != 0 || counter1 != 0))
                            {
                                if (counter + counter1 + x == str2.Length - 1)
                                {
                                    Console.WriteLine(str3);
                                }
                            }
                        }

                        counter = 0;
                        counter1 = 0;

                        if (x > pattern.Length)
                        {
                            for (int l = 0; l < str2.Length; l++)
                            {

                                if (l > x && pattern[0] == '*' && str2[l] == pattern[l - x])
                                {
                                    counter++;
                                }

                                else if (l + 1 <= pattern.Length && pattern[pattern.Length - 1] == '*' && str2[l] == pattern[l])
                                {
                                    counter1++;
                                }

                            }
                            if (pattern[0] == '*' && (counter != 0 || counter1 != 0))
                            {
                                if (counter + counter1 + x == str2.Length - 1)
                                {
                                    Console.WriteLine(str3);
                                }
                            }
                            if (pattern[pattern.Length - 1] == '*' && (counter != 0 || counter1 != 0))
                            {
                                if (counter + counter1 + x == str2.Length - 1)
                                {
                                    Console.WriteLine(str3);
                                }
                            }
                        }
                    }

                    if (pattern[0] == '*' && pattern[pattern.Length - 1] == '*')
                    {
                        Console.WriteLine(str3);
                    }
                    counter = 0;
                    counter1 = 0;
                }

            }


            

            Console.ReadLine();
        }
    }
}
