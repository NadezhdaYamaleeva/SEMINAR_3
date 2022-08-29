// Принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N");
double n = double.Parse(Console.ReadLine());
Console.Write(n + "->");
n = Math.Abs(n);
for (int i = 1; i <= n; i ++)
{
    Console.Write(Math.Pow(i, 3) + ",");
}