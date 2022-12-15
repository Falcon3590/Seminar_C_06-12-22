// Задача 3 Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// Указание: Вывод массива вынести в отдельную функцию.

Console.WriteLine("Введите число N");

int n = int.Parse(Console.ReadLine());

int [] array = new int[n];

Console.Write("[");

for (int i = 0; i < n; i++)

    {
       
       array[i] = Convert.ToInt32(Math.Pow(i + 1, 3));  
       Console.Write($"{array[i] }, ");
                           
    }

Console.WriteLine("]");
