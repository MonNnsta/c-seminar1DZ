Console.WriteLine ("Введите 1е число");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2е число");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
if (usernumber1 > usernumber2)
{
    Console.WriteLine("Большее число - " + usernumber1);
    Console.WriteLine("Меньшее число - " + usernumber2);
}
else
{
    Console.WriteLine("Меньшее число - " + usernumber1);
    Console.WriteLine("Большее число - " + usernumber2);
}
