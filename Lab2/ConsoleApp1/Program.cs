using System.Diagnostics;

class Program{
    static void Main(){
        int userSizeArray = 0;
        int[] array;
        Console.WriteLine("Ввведите размер массива");
        string userInput = Console.ReadLine();

        while (!int.TryParse(userInput, out userSizeArray) ||
            userSizeArray <= 0){

            Console.WriteLine("Такое значение не подходит");

            userInput = Console.ReadLine();
        }


        Console.WriteLine("Введите значниея массива");
        array = new int[userSizeArray];
        for(int i = 0; i < array.Length; i++){
            string userNumberTypeString = Console.ReadLine();
            int userNumber = 0;
            while(!int.TryParse(userNumberTypeString, out userNumber)){
                Console.WriteLine("Такой тип данных не подходит");
                userNumberTypeString = Console.ReadLine();
            }

            array[i] = userNumber;
        }



        int min = array[0];

        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }


        for(int i = 1; i < array.Length; i++){
            if(min > array[i]){
                Console.WriteLine("\nNo");
                return;
            }
            min = array[i];
        }
        Console.WriteLine("\nYes");

    }

}
