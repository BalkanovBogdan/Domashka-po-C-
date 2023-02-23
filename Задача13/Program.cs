//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число.");
int num=int.Parse(Console.ReadLine());
if(99<num)
{
    while(num>1000){num=num/10;}Console.WriteLine($"Третья цифра ->{num%10}");
}
else {Console.WriteLine("Отсутствует третье число");} 
