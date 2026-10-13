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

        StringBuilder builder = new StringBuilder(userInpurtString);

        Console.WriteLine("Введите любую подстроку для удаления:");
        string userSubStr = Console.ReadLine();
        builder.Replace(userSubStr, "");
        string empty = string.Empty;

        string[] words = builder.ToString().Split(" ");
        
        printLine();
        
        foreach(string i in words)
        {
            if(i.Length == 0)
            {
                continue;
            }
            if(empty.Length > 0)
            {
                empty += " ";
            }
            empty += i;

        }

        Console.WriteLine(empty);
        
    }


    public static void printLine()
    {
        Console.WriteLine("----------------------------");
    }
}