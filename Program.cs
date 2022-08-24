Console.Clear();


// Задание 34

int[] array = new int[4];
Random rnd = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(99, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
var str = string.Join(", ", array);
Console.WriteLine("Задача 34");
Console.WriteLine($"Массив состоит из чисел {str}");
Console.WriteLine($"Количество четных чискл в массиве: {count}");
Console.WriteLine();


// Задача 36

int[] array1 = new int[4];
Random rnd1 = new Random();
int count1 = 0;
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rnd1.Next(-99, 100);
    if (i % 2 == 1)
    {
        count1 += array1[i];
    }
}
var str1 = string.Join(", ", array1);
Console.WriteLine("Задача 36");
Console.WriteLine($"Массив состоит из чисел {str1}");
Console.WriteLine($"Сумму элементов стоящих на нечётных позициях: {count1}");
Console.WriteLine();


// Задача 38

int[] array2 = new int[5];
Random rnd2 = new Random();
int max = -100;
int min = 100;
for (int i = 0; i < array2.Length ; i++)
{
    array2[i] = rnd2.Next(-99, 100);
    if (array2[i] < min)
    {
        min = array2[i];
    }
    if (array2[i] > max)
    {
        max = array2[i];
    }
}
int diff = max - min;
var str2 = string.Join(", ", array2);

Console.WriteLine("Задача 38");
Console.WriteLine($"Массив: {str2}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Разница: {diff}");