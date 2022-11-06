// Задача 29: 
// Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
// Вариант решения с заполнением массива случайными числами.

int Start()
{
    Console.Write("Введите количество элементов в массиве: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

void FillMassive (int[] list)
{
    Console.WriteLine("Массив случайных чисел:");
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(1, 10);
        Console.Write(list[i] + " ");
    }
    Console.WriteLine(" ");
}

int N = Start();
int[] array = new int[N];

FillMassive(array);