using System.Net;
using System.Text;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите любое слово:");
        string userInpurtString = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(userInpurtString))
        {
            Console.WriteLine("Строка пустая, введите снова предложение");
            userInpurtString = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder(userInpurtString);

        

        for(int i = sb.Length - 1; i >= 0; i--)
        {
            if (char.IsPunctuation(sb[i]))
            {
                sb.Remove(i, 1);
            }
        }

        string[] words = sb.ToString().Split(" ");
        sb.Clear();

        int minLengthWord = words[0].Length;
        for(int i = 0; i < words.Length; i++)
        {
            if (minLengthWord > words[i].Length)
            {
                minLengthWord = words[i].Length;
            }
        }

        Console.WriteLine("min length word: " + minLengthWord);

        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Length == minLengthWord)
            {
                sb.Append(words[i] + " ");
            }
        }
        Console.WriteLine("Самые короткие слова предложения");
        Console.WriteLine(sb);

    }
}