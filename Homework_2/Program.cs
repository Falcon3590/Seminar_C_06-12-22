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
                                   1.0), 0.5);
        Console.WriteLine("Расстояние между точками 1 и 2 = " + temp); // вывод результата на консоль
        return;
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
        
    // Double x1 = 2; // можно хардкодом объявить переменную
    // Double y1 = -5;
    // Double z1 = 7;
    // Double x2 = 3;
    // Double y2 = 4;
    // Double z2 = 5;
     
    
    distance(x1, y1, z1,  // передаем полученное значение переменных в метод 
             x2, y2, z2);
}
}
 
// Как результат программа работает и чтото считает, предположительно значение между точками в условных единицах