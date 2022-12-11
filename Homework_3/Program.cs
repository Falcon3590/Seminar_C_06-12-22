// Задача 3 Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// Указание: Вывод массива вынести в отдельную функцию.

Console.WriteLine("Введите число N");

int n = int.Parse(Console.ReadLine());

int size = n + 1;

int [] array = new int[size];


Console.Write("[");

for (int i = 1; i <= n; i++)

    {
       
       array[i] = Convert.ToInt32(Math.Pow(i, 3));  
       Console.Write($"{array[i] }, ");
              
    }

Console.WriteLine("]");


//int count = Convert.ToInt32(Math.Pow(i, 3));

// for (int i = 1; i <= n; i++) 

// Понятия не имею как масив в данной ситуации вывести отдельной функцией на консоль


// не доведенные до успеха мысли в слух о том как вывод массива вынести в отдельную функцию

// Вопросы которые возникли: Как возвращать массив; как в переменную выгрузить данные операции Math.Pow(i, 3); как передавать переменные из функции в функцию; почему в методе не получается объявить нужные мне переменные и можно ли это делать...

// class Program
// {
 
//      void Main(string[] args)
//     {
//         Console.WriteLine("Введите число N");
//         int n = int.Parse(Console.ReadLine());
//         for (int i = 1; i <= n; i++)
//         Console.WriteLine(Math.Pow(i, 3));
//         ArrCube("d");
//         Console.ReadKey(true);
//         return;
        

//     }

//     public static void ArrCube(string str)
//     {
//         Console.WriteLine (str);
//     }

        
// }

// void PrintArray(int[] array)
// {
// int count = array.Length;

// for (int i = 0; i < count; i++)
//     {
//     System.Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// PrintArray(arr);



    //     void Main(string[] args)
    // {
        
    //     Console.WriteLine("Введите число N");
    //     int n = int.Parse(Console.ReadLine());
    //     string[] array = new string[n]; 

    //     Console.WriteLine("[");

    //     for (int i = 1; i <= n; i++)
    //     {
    //         int result = Convert.ToInt32(Math.Pow(i, 3));  
    //         Console.Write();
    //     }

    //     Console.WriteLine("]");
    //  }