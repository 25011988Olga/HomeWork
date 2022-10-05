Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("первое число max, второе min");
}
if(a<b)
{
    Console.WriteLine("Первое число min,второе max");
}
if(a==b)
{
    Console.WriteLine("Числа равны,введите новую пару чисел");
}
