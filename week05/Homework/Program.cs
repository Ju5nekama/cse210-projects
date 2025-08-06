using System;

namespace math 
{
    class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assign =new  WritingAssignment("Kama","Addition","This has been challenging");

        Console.WriteLine(assign.GetString());
        Console.WriteLine($"{assign.GetWritingInformation()}");
    }
}
}