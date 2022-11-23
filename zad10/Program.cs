/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей
 цифры нет.*/

Console.Write("Enter the Number: ");
int AnyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(AnyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("Third digit: " + anyNumberText[2]);
}
else
{
    Console.WriteLine("No third digit");
}