// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
while(number < 10000 || number >= 100000)
{
    Console.WriteLine("Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
}
int a = number/10000;
int b = number%10;
int c = (number/1000)%10;
int d = (number%100)/10;
if (a == b && c == d)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}