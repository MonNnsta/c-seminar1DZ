Console.WriteLine("Введите число, а я скажу вам четное оно или нет :) ");
int usernumber = Convert.ToInt32(Console.ReadLine());
if (usernumber % 2 == 0)
    Console.WriteLine("Ваше число четное! ");
else
    Console.WriteLine("Ваше число не четное! ");