// Два друга шли на встречу друг к другу.
int count=0;
int distance=10000;
int F1speed =1;
int F2speed =2;
int Dspeed =5;
int friend=2;
int time=0;

while(distance>10)
{
    if(friend==1)
    {
        time=distance/(F1speed+Dspeed);
        friend=2;
    }
    else
    {
        time=distance/(F2speed+Dspeed);
        friend=1;
    }
distance=distance+(F1speed+F2speed)*time;
count++;
}
Console.WriteLine("Количество раз пробежала собака " + count);