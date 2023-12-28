using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

class Day1
{
    public static void DoSomething(List<string> strings)
    {
        int? final = null;
        
        for (int i = 0; i < strings.Count; i++)
        {
            strings[i] = ChangeWordsToNumbers(strings[i]);

            var first = GetFirstNumber(strings[i]);
            var last = GetLastNumber(strings[i]);

            Console.WriteLine($"{strings[i]} {first} {last}");

            int combo = int.Parse($"{first}{last}");

            final = final == null ? combo : final + combo;
        }

        Console.WriteLine("final: " + final);
    }

    static string ChangeWordsToNumbers(string str)
    {
        Dictionary<string, string> numberDictionary = new Dictionary<string, string>()
        {
            { "nine", "nine9nine" },
            { "eight", "eight8eight" },
            { "seven", "seven7seven" },
            { "six", "six6six" },
            { "five", "five5five" },
            { "four", "four4four" },
            { "three", "three3three" },
            { "two", "two2two" },
            { "one", "one1one" }
        };

        foreach (string key in numberDictionary.Keys)
        {
            if (str.Contains(key))
            {
                str = str.Replace(key, numberDictionary[key].ToString());
            }
        }

        return str;
    }


    static int GetFirstNumber(string str)
    {
        int first = 0;

        for(int i = 0; i < str.Length; i++){
            if (char.IsDigit(str[i]))
            {
                first = int.Parse(str[i].ToString());
                break;
            }
        }

        return first;
    }
    
    static int GetLastNumber(string str)
    {
        int last = 0;

        for(int i = str.Length - 1; i >= 0; i--){
            if (char.IsDigit(str[i]))
            {
                last = int.Parse(str[i].ToString());
                break;
            }
        }

        return last;
    }
}