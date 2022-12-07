//Использую для вычесления формулу: Расстояние =  Корень из (x2-x1)^{2} + (y2-y1)^{2} + (z2-z1)^{2}

class PointsDis // метод или функция не может существовать без класса, поэтому создаю класс и даю ему название близкое к теме.
{
     
    static void distance(float x1, float y1, // использую модификатор static; тип возвращаемых данных "ничего"; название метода назначил сам "дистанция" 
                     float z1, float x2,     // ввожу не целочисленные переменные 
                     float y2, float z2)
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
    float x1 = 2;
    float y1 = -5;
    float z1 = 7;
    float x2 = 3;
    float y2 = 4;
    float z2 = 5;
     
    // function call
    // for distance
    distance(x1, y1, z1,
             x2, y2, z2);
}
}
 
// This code is contributed
// by chandan_jnu.
