M: Console.Write(" Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if (99<a && a<1000){
//string text = Console.ReadLine();
//int y = text[text.Length - 1] - '0';
//Console.Write("Последняя цифра нашего числа: " );
//Console.WriteLine (y);
switch ( a % 10)
{
    case 0: 
        b = 0;
        break;
    case 1:
        b = 1;
        break;
    case 2:
        b = 2;
        break;
    case 3:
        b = 3;
        break;
    case 4:
        b = 4;
        break;
    case 5:
        b = 5;
        break;
    case 6:
        b = 6;
        break;
    case 7:
        b = 7;
        break;
    case 8:
        b = 8;
        break;
    case 9:
        b = 9;
        break;
}
}
else{
    goto M;
}
Console.Write( $"Последняя цифра числа {a} = {b}");