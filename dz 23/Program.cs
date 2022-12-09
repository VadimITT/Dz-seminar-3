Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0;i< n;i++)
{
    Console.Write($"{Math.Pow(i, 3)},"); 
}


