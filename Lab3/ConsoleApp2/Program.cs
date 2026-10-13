internal class Program
{
    public static void Main()
    {
        int userNumber = 1;
        while(userNumber != 0)
        {
            Console.WriteLine("Введите любое число");
            string userInputNumber = Console.ReadLine();
            while(!int.TryParse(userInputNumber, out userNumber))
            {
                Console.WriteLine("Такое значение не подходит");
                userInputNumber = Console.ReadLine();
            }
            Numbers(userNumber);

        }

    }


    public static void Numbers(int userNumber)
    {
        int count = 0;
        if(userNumber == 0)
        {
            return;
        }


        if(userNumber < 0)
        {
            userNumber = Math.Abs(userNumber);
        }

        int copyUserNumber = userNumber;
        for(int i = 1; i <= userNumber; i++)
        {
            if(copyUserNumber % i == 0)
            {
                count++;
            }    
        }
        Console.WriteLine("Общее количество делителей: " + count +
         "\nc отрицательными: " + (count * 2));
    }
}