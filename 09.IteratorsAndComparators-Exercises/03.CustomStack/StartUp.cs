﻿namespace _03.CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            string input;
            string[] delims = { ", ", " " };

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(command[i]);
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No elements");
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
