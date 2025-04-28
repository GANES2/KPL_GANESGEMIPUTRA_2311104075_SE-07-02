using System;

class Utilities
{
    public static char GetValidCharacter(string message)
    {
        char input;
        do
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            if (userInput.Length == 1 && Char.IsLetter(userInput[0]))
            {
                input = Char.ToUpper(userInput[0]);
                return input;
            }

            Console.WriteLine("Input tidak valid! Masukkan satu huruf kapital.");
        } while (true);
    }
}
