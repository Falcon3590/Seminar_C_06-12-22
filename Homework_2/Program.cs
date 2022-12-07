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
        Console.WriteLine("Расстояние между точками: " + temp);
        return;
    }
 
// Код с указанием координат
public static void Main()
{
    Console.WriteLine("Введите координаты х1=");
    int coor_x1 = Int32.Parse(Console.ReadLine());
    Double x1 = Convert.ToDouble(coor_x1);
     
    Console.WriteLine("Введите координаты у1=");
    int coor_y1= Int32.Parse(Console.ReadLine());
    Double y1 = Convert.ToDouble(coor_y1);

    Console.WriteLine("Введите координаты z1=");
    int coor_z1 = Int32.Parse(Console.ReadLine());
    Double z1 = Convert.ToDouble(coor_z1);

    Console.WriteLine("Введите координаты х2=");
    int coor_x2 = Int32.Parse(Console.ReadLine());
    Double x2 = Convert.ToDouble(coor_x2);
 
    Console.WriteLine("Введите координаты у2=");
    int coor_y2 = Int32.Parse(Console.ReadLine());
    Double y2 = Convert.ToDouble(coor_y2);
    
    Console.WriteLine("Введите координаты z2=");
    int coor_z2= Int32.Parse(Console.ReadLine());
    Double z2 = Convert.ToDouble(coor_z2);
    
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
 
