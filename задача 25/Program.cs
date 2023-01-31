Console.Clear();
Console.WriteLine("Vvedite chisla: ");
double n =Convert.ToDouble(Console.ReadLine());
int m=Convert.ToInt32(Console.ReadLine());
double i=0;
double k = 1;
if (m>0)
{
while (i<m)
{k=k*n; i++;}
}
if (m==0)
{k=1;}


Console.WriteLine(k);