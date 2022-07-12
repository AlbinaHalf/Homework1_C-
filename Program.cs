//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.Write("Enter a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("The number A is a greater, the number B is less");
}
else
{
    Console.WriteLine("The number B is a greater, the number A is less");
}
