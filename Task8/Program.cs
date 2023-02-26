Console.WriteLine("Введите число, а я покажу вам все четные числа, которые были до этого числа! ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int number = 2;
while (number <= usernumber)
{
    Console.Write(number + "  ");
    number = number + 2;}

