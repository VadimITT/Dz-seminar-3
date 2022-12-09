Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
if (a.Length == 5)
{
    if (a[1] == a[4] && a[2] == a[3])
    {
        Console.WriteLine("Число " + a + " Являеться Полиндромом ");
    }
    else
    {
        Console.WriteLine("Число не явялеться полиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}