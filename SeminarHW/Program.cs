// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if(numberA > numberB)
//     Console.WriteLine($"{numberA} больше {numberB}");
// else 
//     Console.WriteLine($"{numberB} больше {numberA}");



// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максиальное из этих чисел.

// Console.Write("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int C = Convert.ToInt32(Console.ReadLine());
// if(A > B & A > C)
//     Console.WriteLine($"{A} больше всех");
// else if(A > B & A < C)
//     Console.WriteLine($"{C} больше всех");
// else if(A < B & A > C)
//     Console.WriteLine($"{B} больше всех");
// else if(A < B & A < C & B < C)
//     Console.WriteLine($"{C} больше всех");
// else
//     Console.WriteLine($"{B} больше всех");


// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA%2 == 0)
//     Console.WriteLine($"{numberA} четное");
// else 
//     Console.WriteLine($"{numberA} не четное");


// Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count <= number)
// {
//         if(count%2 == 0)
//         Console.Write(count+" ");
//         count++;
// }


// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

// int Line(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num/10 % 10;
//     return (dec);
// }    
// int res = Line();
// Console.WriteLine(res);


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void Test(int num){
//     if (num < 100)
//             Console.WriteLine ($"Третьей цифры нет");
//     else
//     {
//         while(num > 999)
//         {
//             num = num / 10;
//         }
//         int res = num % 10;
//         Console.WriteLine ($"Третья цифра в числе {res}");
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number == 6 || number == 7)
//     Console.WriteLine("Выходной");
//     else if(number < 1 || number > 7)
//     Console.WriteLine("Нет такого дня");
// else 
//     Console.WriteLine("Опять работать");


// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom5(int num)
// {
//     if(num<10000 || num>99999)
//     Console.WriteLine ("Число не пятизначное");
//     int temp = num;
//     int reverse = 0;
//     while (num > 0)
//         {
//             reverse = reverse*10 + num%10;
//             num = num/10;
//         }
//     if (reverse == temp)
//         Console.WriteLine ("Палиндром");
//     else 
//         Console.WriteLine ("Не палиндром");
// }
// 
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Palindrom5(x);


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance (int x1, int y1, int x2, int y2, int z1, int z2)
// {
//     double Dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//     return Dist;
// }
// 
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double dist = Distance(x1,x2,y1,y2,z1,z2);
// Console.WriteLine(dist);


// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

// void Triple(int number)
// {
//      for (int count = 1; count <= number; count++)
//      {
//      Console.Write(count*count*count + " ");
//      }
// }
// 
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Triple(x);