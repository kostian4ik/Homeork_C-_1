/*
// Задача№2: Программа каторая на входе запрашивает 2 числа и выдает какое число больше, а какое меньше.

Console.WriteLine ("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите первое число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine ("Первое число" + number_1 + "Больше чем втарое " + number_2);
}
else
{
    Console.WriteLine ("Второе число" + number_2 + "Больше чем первое " + number_1);
}
*/



/*
//Задача№4: Программа, которая принимает на входе три числа и выдает максимальное из этих 3х чисел.


Console.WriteLine("Введите 3 числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;
if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
max = number_3;
}

Console.WriteLine ("Наибольшее из введеных чисел " + max);
*/


/*
//Задача№6: Программа которая на входе принимает число и выдает является ли число четным (делится на 2 без остатка).

Console.WriteLine ("Ввидите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
  Console.WriteLine ("Число " + number + " Является - нечетным");
}
else
{
    Console.WriteLine ("Число " + number + " Является - четным");
}
*/

/*
//Задача№8: Программа которая на входе принимаен число N, а на выходе показывает все четные числа от 1 до N.


int i = 1;
bool not = true;

Console.WriteLine ("Введите число");
int number_N = Convert.ToInt32 (Console.ReadLine());
 
 Console.WriteLine ("Четное число от 1 до " + number_N);
 while (i <= number_N)
{
    if (i % 2 != 1)
    {
       Console.WriteLine (i + ", ");
       not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine ("Нет четных чисел");
}
*/