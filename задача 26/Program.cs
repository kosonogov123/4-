Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i=0;
while (n>0)
{n=n/10;
    i=i+1;}
Console.WriteLine(i);