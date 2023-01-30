System.Console.Write(">>> ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];

Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    massiv[i] = rnd.Next(-100,100);
    System.Console.Write(massiv[i] + " ");
}

int sum =0;

for (int i = 0; i < n; i++)
{
    if (i%2!=0)
    {
        sum=sum+massiv[i];
    }
    
}
System.Console.WriteLine("\n Сумма = " + sum);

