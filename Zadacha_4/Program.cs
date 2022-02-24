// Показать числа от -N до N
Console.Write(" Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int x = a; x <= b; x++ )
{
    Console.Write( x );
    Console.Write(" ");

}