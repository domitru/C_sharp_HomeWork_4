// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// пример:
//             452 -> 11
//             82 -> 10
//             9012 -> 12


int SummaCifr(int n)
{          
    int s = 0;
    while(n!=0)
    {
        s = s + n % 10;
        n = n / 10;
    }
    return s;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = SummaCifr(n);
Console.WriteLine("Сумма чисел равна: {0}",num);



/*
Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while(n!=0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Сумма чисел равна: {0}",s);
*/