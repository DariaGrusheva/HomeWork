// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (number == 1)
{
    Console.Write("В промежутке до 1 нет четных натуральных чисел.");
}
else
{
    Console.Write("Промежуток (от 1 до введенного Вами числа) содержит следующие четные числа: ");
    while (i <= number)
    {
        if (i < number - 1)
        {
            Console.Write(i + ", ");
        }
        else if (i == number - 1)
        {
            Console.Write(i + ".");
        }
        else
        {
            Console.Write(i + ".");
        }

        i = i + 2;
    }
}