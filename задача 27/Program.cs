Console.Clear();
Console.WriteLine("vvedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n>0)
{ int m = n%10;
    i =i+m;
    n=n/10; }
    Console.WriteLine(i);