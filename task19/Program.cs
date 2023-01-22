Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int x = n;
int a2 = 0;
int a1 = n/10000;
int a5 = (n%10);
int a4 = (n%100)/10;
while(i<3)
{
    x = (x/10);
    a2 = (x%10);
    i=i+1;
}
Console.WriteLine($"{a1},{a2},{a4},{a5}");
if((a1 == a5) && (a2==a4))
Console.WriteLine("палиндром");
else 
Console.WriteLine("НЕ палиндром");
