using System;

namespace FundFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Translate")
                {
                    string curr = command[1];
                    string replacement = command[2];

                    input = input.Replace(curr, replacement);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Includes")
                {
                    Console.WriteLine(input.Contains(command[1]));
                }
                else if (command[0] == "Start")
                {
                    bool startsWith = true;
                    string check = command[1];

                    for (int i = 0; i < check.Length; i++)
                    {
                        if (check[i] != input[i])
                        {
                            startsWith = false;
                            break;
                        }
                    }

                    Console.WriteLine(startsWith);
                }
                else if (command[0] == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command[0] == "FindIndex")
                {
                    string character = command[1];
                    Console.WriteLine(input.LastIndexOf(character[0]));
                }
                else if (command[0] == "Remove")
                {
                    input = input.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(input);
                }

                command = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            //100/100
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
