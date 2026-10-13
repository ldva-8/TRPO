using System.Text;

    internal class Program
    {
        static void Main()
        {

            string poems = "тучки небесные вечные странники";
            char[] div = { ' ' }; 

            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части: ");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);

            }
            string whole = String.Join(" | ", parts.Reverse());
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(whole);

        }

    }
