// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int Start()
{
    Console.Write("Введите число: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int DigitQ(int input)
{
    int count = 0;
    while (input > 0)
    {
        input = input / 10;
        count++;
    }
    return count;
}

void DigitSumm(int input, int count)
{
    int[] array = new int[count];
    int summ = 0;
    for (int i = 0; i < count; i++)
    {
        int num = input % 10;
        array[i] = num;
        input = input / 10;
    }
    for (int j = 0; j < array.Length; j++)
    {
        summ = summ+array[j];
    }
    Console.WriteLine("Сумма цифр введенного числа = " + summ);
}

int insert = Start();
int amount = DigitQ(insert);
DigitSumm(insert, amount);