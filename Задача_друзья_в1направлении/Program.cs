// Два друга шли в одном направлении.
int count=0;
int distance=10000;
int F1speed =2;
int F2speed =1;
int Dspeed =5;
int friend=2;// равняется 2 , значит бежит собака от 1 ко 2 другу.
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
        time=distance/(F2speed-Dspeed);
        friend=1;
    }
distance=distance+(F1speed+F2speed)*time;
count++;
}
Console.WriteLine("Количество раз пробежала собака " + count);
