class Program{
    public static void Main(){
        int x = 0;
        int y = 0;

        Console.WriteLine("Введите значение x");
        string userNumberInputX = Console.ReadLine();

        while(!int.TryParse(userNumberInputX, out x))
        {
            Console.WriteLine("Такое значение для x не подходит введите числа заново");
            userNumberInputX = Console.ReadLine();
        }

        Console.WriteLine("Введите значение y");
        string userNumberInputY = Console.ReadLine();
        while(!int.TryParse(userNumberInputY, out y))
        {
            Console.WriteLine("Такое значение для y не подходит введите числа заново");
            userNumberInputY = Console.ReadLine();
        }

        
        int z = Max(x, 2 * y - x) + Max(5 * x + 3 * y, y);
        Console.WriteLine("z = " + z);


    }

    static int Max(int a, int b){
        return a > b ? a : b;
    }
}