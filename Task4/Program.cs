double pointDistance (string str)
{
    double res =0;
    if(str == "2d")
    {
        
        Console.Write("Введите координаты точки x1: ");
        int x1 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки y1: ");
        int y1 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки x2: ");
        int x2 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки y2: ");
        int y2 = int.Parse(Console.ReadLine());
        res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
       
    }
      if(str == "3d")
    {
        
        Console.Write("Введите координаты точки x1: ");
        int x1 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки y1: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("Введите координаты точки z1: ");
        int z1 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки x2: ");
        int x2 = int.Parse(Console.ReadLine());
         Console.Write("Введите координаты точки y2: ");
        int y2 = int.Parse(Console.ReadLine());
        Console.Write("Введите координаты точки z2: ");
        int z2 = int.Parse(Console.ReadLine());
        res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    }
        return res;
}

Console.Write("Введите вариант плоскости 2d или 3d:");
string method = Console.ReadLine();
Console.WriteLine("Расстояние между точками = "+pointDistance(method));
