//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num=int.Parse(Console.ReadLine());
int result=0;
if(99<num && num<1000)
{
    result=((num-num%10)%100)/10;
    Console.WriteLine($"Второе число->{result}.");
}
else
{
    Console.WriteLine("Введенно не трехзначное число, повторите заново.");
}