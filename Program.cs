// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class capitalization
{
    public static List<int> capitals(string input)
    {
        List<int> capitalLetters = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsUpper(input[i]))
            {
                capitalLetters.Add(i);
            }
        }
        return capitalLetters;
    }
    public static void Main(string[] args)
    {
        string testing = "NewAttemptFor!MThis";
        List<int> test = capitals(testing);
        foreach (int i in test)
        {
            Console.WriteLine(i);
        }

    }
}