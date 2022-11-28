// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// int n = 0;
// while (n < 10000 || n > 99999)
// try {
//     Console.Write("Введите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// catch {
//     Console.WriteLine("Нужно ввести пятизначное число! Попробуйте снова");
// }
// if ((n / 10000 == n % 10) && ((n / 1000 - (n / 10000) * 10) == ((n % 100) - n % 10) / 10))
//     Console.WriteLine("Это палиндром.");
// else
//     Console.WriteLine("Это не палиндром. ");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");


// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }

// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }