﻿Console.Clear();  // Очищаю консоль для удобства

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!); // Ввод числа от пользователя

    if(number >= 10000 && number <= 99999) // использовал двойную опресанту для внесения второго условия, еще можно использовать ||
    {
        int integer1 = number / 10000; // ввел новую переменную для операции целочисленного деления, получаем первую цифру номера
        int remainder = number % 10; // ввел новую переменную для операции деления с остатком, получаем последнюю цифру номера
 
            if(integer1 == remainder) // полученные первое и последние число сравниваем, если одинаковые выполняем условия
            {
                number = number / 10; // делим без остатка, остаются первые 4 цифры
                int integer2 = (number / 100) % 10; // (делим без остатка, остаются первые 2 цифры) делим полученное с остатком получаем вторую цифру номера)
                int remainder2 = number % 10; // получаем четвертую цифру номера
                if(integer2 == remainder2) // если цифры равны то можно считать что число является палиндромом
                    {
                        Console.WriteLine($"Число {number} является палиндромом");
                    }
                else 
                    {
                        Сonsole.WriteLine("error")
                    }
            }
            else 
            {
                Console.WriteLine($"Число {number} не является палиндромом");
            }
            
    }
    else
    {
        Console.WriteLine("Некорректное число! Введите пятизначное число!");
    }

 

