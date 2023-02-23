// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число соответствующий дню недели.");
int num=int.Parse(Console.ReadLine());
if(num<6 && num>0){Console.WriteLine("Будний-рабочий день");} 
else if(num>5 && num<8){Console.WriteLine("Сегодня выходной день.");}
    else{Console.WriteLine("Введено не верное число, повторите попытку. ");}