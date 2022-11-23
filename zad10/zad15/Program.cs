/*15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

Console.Write("Введите порядковый номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Неделя состоит из 7 дней!");
    }
    else Console.WriteLine("Это будний день");
}

CheckingTheDayOfTheWeek(dayNumber);
