using System.Text;

internal class Program{
    public static void Main(){
        Console.WriteLine("Введите любое слово");
        string userInpurtString = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(userInpurtString))
        {
            Console.WriteLine("Строка пустая, введите снова предложение");
            userInpurtString = Console.ReadLine();
        }

        string reworkWordUser = "";

        for(int i = 0; i < userInpurtString.Length; i++)
        {
            if (userInpurtString[i].CompareTo(':') == 0)
            {
                break;
            }
            reworkWordUser += userInpurtString[i];
        }

        Console.WriteLine("Вывод символов до символа \":\" -> " + reworkWordUser);


    }
}