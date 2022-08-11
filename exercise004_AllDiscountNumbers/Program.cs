//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (number < 1) 
{
    Console.WriteLine("Указанное число выходит из диапозона интервала, введите число > 1");
}

else
{
    if (number < 2) 
    {
        Console.WriteLine("В интервале от 1 до " + number + " нет четных чисел");
    }
    else 
    {
            while (count <= number)
            {
                if (count % 2 == 0)
                {
                    Console.Write(count + " ");
                }

            count++;
            }
    }
}