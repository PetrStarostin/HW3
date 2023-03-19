//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// bool IsPolindrome(int num)
// {
//     int temp = num ; 
//     int reverb = 0 ; 
//     while(num > 0)
//     {
//         int grab = num % 10;
//         reverb = reverb * 10 + grab ; 
//         num = num / 10 ;
//     }
//     if(temp == reverb) return true ; 
//     else return false ; 
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(IsPolindrome(number))
//     Console.WriteLine($"Число {number} полиндром");
// else 
//     Console.WriteLine($"Число {number} не полиндром");

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// double DistanceLine(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int dot1 = x1 - x2 ;
//     int dot2 = y1 - y2 ;
//     int dot3 = z1 - z2 ;
//     double length = Math.Sqrt(dot1 * dot1 + dot2 * dot2 + dot3 * dot3);
//     return length;
// }
// Console.Write("Введите значение точки x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение точки y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение точки z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение точки x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение точки y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение точки z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Длинна состовляет: {DistanceLine(x1,y1,z1,x2,y2,z2)}");

