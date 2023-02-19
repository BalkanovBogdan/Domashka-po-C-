// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите два числа подрят");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
if(a*a==b || Math.Pow(b,2)==a)
{
    Console.WriteLine("является квадратом");
}
else
{
    Console.WriteLine("не является квадратом");
}