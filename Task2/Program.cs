//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
int square_1 = number_1 * number_1;
Console.WriteLine("Квадрат первого числа = "+square_1);
int square_2 = number_2 * number_2;
Console.WriteLine("Квадрат второго числа = "+square_2);
if(square_1 == square_2) Console.WriteLine("Число "+number_1 +"является квадратом второго числа");
else Console.WriteLine("Число "+number_1 +" не является квадратом числа "+number_2);

/*
Вариант 2 через ввод второго числа в квадрате и нахождении значения его корня сравнивая его с 1 числом, но данный метод будет не удобен при больших числах. Хотя и можно возводить 
в квадрат число 2 и потом вычислять его квадратный корень, но мне кажется это действие будет излишним.
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число в квадрате: ");
int number_2 = int.Parse(Console.ReadLine());
double sqrt = Math.Sqrt(number_2);
Console.WriteLine("Корень числа number_2 = "+sqrt);
if(number_1 == sqrt) Console.WriteLine("Число "+number_1 +"является квадратом второго числа");
else Console.WriteLine("Число "+number_1 +" не является квадратом числа "+number_2);
*/
