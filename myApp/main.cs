class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0){

            List<string> strings;
            
            switch(args[0]){
                case "1":
                    strings = File.ReadAllLines(@"C:\Users\samfi\OneDrive\Desktop\WERK\Advent\myApp\inputs\input1.txt").ToList();
                    Day1.DoSomething(strings);
                    break;
                case "2":
                    strings = File.ReadAllLines(@"C:\Users\samfi\OneDrive\Desktop\WERK\Advent\myApp\inputs\input2.txt").ToList();
                    Day2.DoSomething(strings);
                    break;
                case "3":
                    strings = File.ReadAllLines(@"C:\Users\samfi\OneDrive\Desktop\WERK\Advent\myApp\inputs\input3.txt").ToList();
                    Day3.DoSomething(strings);
                    break;
                default:
                    Console.WriteLine("Please provide a day number");
                    break;
            }
        } else {
            Console.WriteLine("Please provide a day number");
        }
    }
}