// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.

int StartA()
{
    Console.Write("Введите число A: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int StartB()
{
    Console.Write("Введите число B: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

void Result(int num1, int num2)
{
    int n = num1;
    if (num1 > 0 | num1 < 0)
    {
        for (int i = 0; i < num2 - 1; i++)
        {
            num1 = num1 * n;
        }
        Console.WriteLine("A в степени B = " + num1);
    }
    if (num1 == 0)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Не определено");
        }
        else
        {
            for (int i = 0; i < num2 - 1; i++)
            {
                num1 = num1 * n;
            }
            Console.WriteLine("A в степени B = " + num1);
        }
    }
}

int a = StartA();
int b = StartB();

Result(a, b);