// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число");
string name = Console.ReadLine();
int numberA = Convert.ToInt32(name);
int max = numberA;

Console.WriteLine("Введите второе число");
string nameB = Console.ReadLine();
int numberB = Convert.ToInt32(nameB);

Console.WriteLine("Введите третье число");
string nameC = Console.ReadLine();
int numberC = Convert.ToInt32(nameC);

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine("Максимальное из этих чисел: ");

Console.WriteLine(max);
