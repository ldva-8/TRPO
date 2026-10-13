using System.Text;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        StringBuilder a = new StringBuilder(Console.ReadLine());

        for (int i = 0; i < a.Length;) {
            if (char.IsPunctuation(a[i]))
            {
                a.Remove(i, 1);

            }
            else ++i;

        }
        string[] s = a.ToString().Split(' ');

        Console.WriteLine("Искомые слова: ");
        foreach (string str in s)
        {
            if (str.Length == 0)
            {
                continue;
            }
            if (str[0] == str[str.Length - 1])
            {
                Console.WriteLine(str);
            }

        }
    }
}
