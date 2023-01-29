int[] massiv = new int[999];

Random rnd = new Random();

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = rnd.Next(100,1000);
    System.Console.Write(massiv[i] + " ");
}
System.Console.WriteLine();

int count = 0;

foreach (var item in massiv)
{
    if (item % 2 == 0)
    {
        count++;
    }
   
}

// for (int i = 0; i < massiv.Length; i++)
// {
//     if (massiv[i]% 2 ==0)
//     {
//         count=count+1;
//     }
    
// }
System.Console.Write("\n Количество четных чисел в массиве: " + count);