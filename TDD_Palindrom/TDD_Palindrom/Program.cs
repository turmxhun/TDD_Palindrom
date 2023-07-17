using System;

class Program
{
    static void Main()
    {
        PalindromEllenor ellenor = new PalindromEllenor();
        string mondat = "Ló szava szól!";
        Console.WriteLine(ellenor.NormalizeMondat(mondat));
        Console.WriteLine(ellenor.ReverseString(ellenor.NormalizeMondat(mondat)));
        Console.WriteLine(ellenor.ReverseString(mondat));

    }
}
