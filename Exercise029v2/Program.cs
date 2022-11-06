// Задача 29: 
// Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
// Вариант решения с заполнением массива чиислами от 1 до N.

int Start()
{
    Console.Write("Введите количество элементов в массиве: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

void FillMassive(int[] list)
{
    int n = 0;
    Console.WriteLine("Массив от 1 до введенного числа:");
    for (int i = 0; i < list.Length; i++)
    {
        n = n + 1;
        list[i] = n;
        Console.Write(list[i] + " ");
    }
    Console.WriteLine(" ");
}

int N = Start();
int[] array = new int[N];

FillMassive(array);