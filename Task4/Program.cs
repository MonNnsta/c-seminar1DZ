Console.WriteLine("Введите 1е число");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int usernumber3 = Convert.ToInt32(Console.ReadLine());
if (usernumber1 > usernumber2 && usernumber1 > usernumber3)
    Console.WriteLine("Максимальное из введенных чисел = " + usernumber1);
else if (usernumber2 > usernumber3)
    Console.WriteLine("Максимальное из введенных чисел = " + usernumber2);
else
    Console.WriteLine("Максимальное из введенных чисел = " + usernumber3);
