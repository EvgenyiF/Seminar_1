// Проверить квадрат
Console.Write("Введите число 1 - ");
int a = Convert.ToInt32(Console.ReadLine()); // Конвертируем строку в целое число
// Вещественное число double и ToDouble у Convert
Console.Write("Введите число 2 - ");
int b = Convert.ToInt32(Console.ReadLine()); // Конвертируем строку в целое число
if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}