Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
while(number>=5)
{
Console.Write("Введите номер четверти: ");
 number = int.Parse(Console.ReadLine());
}
if(number == 1) Console.WriteLine("Первая четверть, координаты х>0 и y>0, т.е х до +бесконечности и y до +бесконечности");
if(number == 2) Console.WriteLine("Вторая четверть, координаты х<0 и y>0, т.е х до -бесконечности и y до +бесконечности");
if(number == 3) Console.WriteLine("Третья четверть, координаты х<0 и y<0, т.е х до -бесконечности и y до -бесконечности");
if(number == 4) Console.WriteLine("Четвёртая четверть, координаты х>0 и y<0, т.е х до +бесконечности и y до -бесконечности");