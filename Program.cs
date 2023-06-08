// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void PrintNum(int N)
// {
//    if (N > 0)
//    {
//       Console.Write(N + " ");
//       PrintNum(N - 1);
//    }
// }
// Console.WriteLine("Inpyt Numbers: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(" -> ");
// PrintNum(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SumElement(int M, int N)
// {
//    if (M > N)
//    {
//       return SumElement(M - 1, N) + M;
//    }
//    else if (N > M)
//    {
//       return SumElement(N - 1, M) + N;
//    }
//    else return N;
// }

// Console.WriteLine("Inpyt Number1: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt Number2: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumElement(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с
//  помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// если n = 0
//   вернуть m + 1
// иначе, если m = 0
//   вернуть ack (n - 1, 1)
// еще
//   вернуть ack(n - 1, ack (n, m - 1))
//стек переполняется
ulong Akerman(ulong n, ulong m)
{
   if (n == 0)
   {
      return m + 1;
   }
   else if (m == 0)
   {
      m = 1;
      return Akerman(n - 1, m);
   }
   else return Akerman(n - 1, Akerman(n, m - 1));
}
Console.WriteLine(Akerman(3, 8));//Akerman(4,m) так стек переполнен , Akerman(3, m) работает