
 /*
 Задача 1: Задайте значения M и N. 
 Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 Использовать рекурсию, не использовать циклы.
 */


// функция натуральные числа от M до N
void NumbersFromMToN(int m, int n)
{
    if (m == n)
        return;
    else
    {
        NumbersFromMToN(m+1, n);
        Console.WriteLine(m);
    }
}

NumbersFromMToN (2, 5);


/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
AkkermanFunction(m,n);

/*
Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
void OutpetElementsInReverseOrder(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        OutpetElementsInReverseOrder(array, i + 1);
        Console.Write(array[i] + " ");
    }
}
int[] array = { 1, 2, 5, 0, 10, 34 };
OutpetElementsInReverseOrder(array);
