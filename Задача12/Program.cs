// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
Console.Clear();
Console.WriteLine("Введите число,два раза");
int num1=int.Parse(Console.ReadLine());
int num2=int.Parse(Console.ReadLine());
int num3=0;
if (num1%num2==0)
{
     Console.WriteLine($"{num1} и {num2}->Кратны");
}   
else
{
     Console.WriteLine($"{num1} и {num2}->Не кратное,остаток-> {num3=num1%num2}");
}