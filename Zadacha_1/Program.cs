// Вывести квадрат числа
Console.Write("Введите число - ");
int numberValue = Convert.ToInt32(Console.ReadLine()); // Конвертируем строку в целое число
// Вещественное число double и ToDouble у Convert
int resaltValue = numberValue * numberValue;
Console.Write("Квадрат числа равен ");
Console.WriteLine(resaltValue);