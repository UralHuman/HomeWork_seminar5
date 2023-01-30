double[] massiv = new double[10];    
Random rnd = new Random();

double minNum = double.MaxValue;
double maxNum = double.MinValue;

for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(1,1000);
        System.Console.Write(massiv[i] + " ");  
    }

System.Console.WriteLine();

foreach (var item in massiv)
{
    if (item<minNum)
    {
        minNum = item;
    }
    else if (item>maxNum)
    {
        maxNum = item;
    }

    
}
System.Console.WriteLine($"\nМаксимальный элемент массива: ({maxNum})\nМинимальный элемент массива: ({minNum})");
System.Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива: ({maxNum-minNum})");

