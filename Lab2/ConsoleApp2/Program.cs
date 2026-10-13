internal class Program{
    static void Main(){

        Random random = new Random();
        int userSizeArray = 0;
        int[] array;
        Console.WriteLine("Ввведите размер массива");
        string userInput = Console.ReadLine();

        while (!int.TryParse(userInput, out userSizeArray) ||
            userSizeArray <= 0){

            Console.WriteLine("Такое значение не подходит");

            userInput = Console.ReadLine();
        }


        array = new int[userSizeArray];
        for(int i = 0; i < array.Length; i++){
            array[i] = random.Next(100);
        }


        Console.WriteLine("Массив:");
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }

       int leftSum = 0;
       int totalSum = array.Sum();
       int minDifference = int.MaxValue;
       int part = 0;
       for (int i = 0; i < array.Length - 1; i++){
            leftSum += array[i];             
            int rightSum = totalSum - leftSum; 

            int currentDifference = Math.Abs(leftSum - rightSum);

            if (currentDifference < minDifference){
                minDifference = currentDifference;
                part = i;
            }
        }


        Console.Write("\nЛевая часть: ");

        for (int i = 0; i <= part; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.Write("\nПравая часть: ");

        for (int i = part + 1; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }


        int newLeftSum = 0;

        for (int i = 0; i <= part; i++)
        {
            newLeftSum += array[i];
        }

        int newRightSum = totalSum - newLeftSum;


        Console.WriteLine("\nСумма левой части: " + newLeftSum);
        Console.WriteLine("Сумма правой части: " + newRightSum);

        Console.WriteLine("Минимальная разница сумм двух частей: " + minDifference);

    }

}