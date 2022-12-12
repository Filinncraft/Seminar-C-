 // Напишите программу, которая принимает на вход координаты точки, причем не равные 0, и выдает номер четверти плоскости, в которой находится эта точка.

// void Segment(int x, int y)
// {
//     if (x==0 || y==0)
//         Console.WriteLine ("Error");
//     else if (x>0 && y>0)
//         Console.WriteLine ("I четверть");
//     else if (x>0 && y<0)
//         Console.WriteLine ("IV четверть");
//     else if (x<0 && y<0)
//         Console.WriteLine ("III четверть");
//     else 
//         Console.WriteLine ("II четверть");
// }
// Console.Write("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Segment(x, y);


// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти.

// void Segment(int q)
// {
//     if (q==1)
//         Console.WriteLine ("Значения Х>0, Значения У>0");
//     else if (q==2)
//         Console.WriteLine ("Значения Х<0, Значения У>0");
//     else if (q==3)
//         Console.WriteLine ("Значения Х<0, Значения У<0");
//     else if (q==4)
//         Console.WriteLine ("Значения Х>0, Значения У<0");
//     else 
//         Console.WriteLine ("Error");
// }
// Console.Write("Введите число: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Segment(q);


// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.

// void Kvadrat(int number)
// {
//         for (int count = 1; count <= number; count++)
//         {
//         Console.Write(count*count + " ");
//         }
// }
// Console.Write("Введите число: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Kvadrat(q);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними

// double Distance (int x1, int y1, int x2, int y2)
// {
//     double Dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
//     return Dist;
// }
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// double dist = Distance(x1,x2,y1,y2);
// Console.WriteLine(dist);