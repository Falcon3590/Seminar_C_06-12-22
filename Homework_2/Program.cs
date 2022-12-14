// Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Использую для вычесления формулу: Расстояние =  Корень из (x2-x1)^{2} + (y2-y1)^{2} + (z2-z1)^{2}

class PointsDis // метод или функция не может существовать без класса, поэтому создаю класс и даю ему название близкое к теме.
{
     
    static void distance(Double x1, Double y1, // использую модификатор static; тип возвращаемых данных "ничего"; название метода назначил сам "дистанция" 
                     Double z1, Double x2,     // ввожу не целочисленные переменные 
                     Double y2, Double z2)
    {
        double temp = Math.Pow((Math.Pow(x2 - x1, 2) +  //использую подсмотренную функцию Math.Pow которая извлекает квадратный корень.
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5); // почему в конце * 1.0), 0.5) не разобрался но работает =) 
        Console.WriteLine("Расстояние между точками 1 и 2 = " + temp); // вывод результата на консоль
        return;

            // альтернативная версия 
            // temp = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - 1z1, 2);
            // temp = Math.Sqrt(temp);
            // temp = Math.Round(temp, 2);
            

    }
 
// Код с указанием координат
public static void Main()
{
    Console.WriteLine("Введите координаты х1=");   // сразу решил принять значение переменных в Double (с плавающей запятой)
    Double x1 = Double.Parse(Console.ReadLine());
         
    Console.WriteLine("Введите координаты у1=");
    Double y1= Double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координаты z1=");
    Double z1 = Double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координаты х2=");
    Double x2 = Double.Parse(Console.ReadLine());
     
    Console.WriteLine("Введите координаты у2=");
    Double y2 = Double.Parse(Console.ReadLine());
        
    Console.WriteLine("Введите координаты z2=");
    Double z2= Double.Parse(Console.ReadLine());
        
    // Double x1 = 34; // можно хардкодом объявить переменную
    // Double y1 = 21;
    // Double z1 = 5;
    // Double x2 = -3;
    // Double y2 = -12;
    // Double z2 = 7;
     
    
    distance(x1, y1, z1,  // передаем полученное значение переменных в метод 
             x2, y2, z2);
}
}
 
// Как результат программа работает и чтото считает, предположительно значение между точками в условных единицах