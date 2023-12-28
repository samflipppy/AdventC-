using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

class Day2
{
    public static void DoSomething(List<string> games)
    {
        int? finalSum = 0;

        for (int i = 0; i < games.Count; i++)
        {
            int gameId = GetGameId(games[i]);
            int start = games[i].IndexOf(':') + 1;
            string remaining = games[i].Substring(start); 
            string[] parts = remaining.Split(';', ',');

            bool pass = true;

            int hiRed = 0;
            int hiGreen = 0;
            int hiBlue = 0;

            foreach (string part in parts)
            {
                var moarParts = part.Split(' ');

                (pass, int num) = CheckParts(moarParts[1].Trim(), moarParts[2].Trim());

                if (moarParts[2] == "red" && num > hiRed)
                    hiRed = num;
                if(moarParts[2] == "green" && num > hiGreen)
                    hiGreen = num;
                if(moarParts[2] == "blue" && num > hiBlue)
                    hiBlue = num;

                // if (!pass)
                //     break;
            }

            // if (pass){
            //     final += gameId;
            // }

            // final = hiRed * hiGreen * hiBlue;

            finalSum += hiRed * hiGreen * hiBlue;
        }

        Console.WriteLine("final:" + finalSum);
    }

    static (bool, int) CheckParts(string num, string color)
    {
        if (color == "red")
            return (int.Parse(num) <= 12, int.Parse(num));

        if (color == "green")
            return (int.Parse(num) <= 13, int.Parse(num));

        if (color == "blue")
            return (int.Parse(num) <= 14, int.Parse(num));
        
        return (false, 0);
    }

    static string GetGame(string input){
        return input.Substring(15, 3);
    } 

    static int GetGameId(string input)
    {
        return int.Parse(input.Substring(5, input.IndexOf(':') - 5));
    }
}