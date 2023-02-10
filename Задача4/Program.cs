// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Ведите три числа,программа выдаст максимальное из трех");
Console.WriteLine("Ведите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите третье число");
int number3 = int.Parse(Console.ReadLine());
int max=number1;

if(max>number2)
{
    if(max>number3)
    {
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max=number3;
        Console.WriteLine("Максимальное число " + max);
    }
}
else
{
    max=number2;
    if(max>number3)
    {
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max=number3;
        Console.WriteLine("Максимальное число " + max);
    }
}