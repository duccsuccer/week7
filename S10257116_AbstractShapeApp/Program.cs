using shape;
using circle;
List<Circle> circleList = new();
InitCircleList(circleList);
while (true)
{
    DispMenu();
    int option = Convert.ToInt32(Console.ReadLine());
    if (option == 0)
    {
        break;
    }
    else if (option == 1)
    {
        int i = 1;
        foreach (var circles in circleList)
        {   
            Console.WriteLine($"[{i} " + circles.ToString());
            i++;
        }
    }
    else if (option == 2)
    {
        foreach (var circles in circleList)
        {
            Console.WriteLine(circles.ToString() + $" Area: {circles.FindArea():F2}");
         
        }
    }
    else if (option == 3)
    {
        foreach (var circles in circleList)
        {
            Console.WriteLine(circles.ToString() + $" Perimeter: {circles.FindPerimeter():F2}");

        }
    }
    else if(option == 4)
    {
        int i = 1;
        foreach (var circles in circleList)
        {
            Console.WriteLine($" [{i}] " + circles.ToString());
            i++;
        }
        Console.Write("Enter circle number: ");
        int cNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter new radius: ");
        double nRad = Convert.ToDouble(Console.ReadLine());
        circleList[cNum - 1].Radius = nRad;
        Console.WriteLine("Radius successfully changed.");
    }
    else if (option == 5)
    {
        Console.Write("Circle color: ");
        string uColor = Console.ReadLine();
        Console.Write("Circle radius: ");
        double uRad = Convert.ToDouble(Console.ReadLine());
        Circle nCircle = new(uColor, uRad);
        circleList.Add(nCircle);
        Console.WriteLine($"New {uColor} circle with radius {uRad:F0}cm added.");
    }
    else if (option == 6)
    {
        int i = 1;
        foreach (var circles in circleList)
        {
            Console.WriteLine($" [{i}] " + circles.ToString());
            i++;
        }
        Console.Write("Enter circle number: ");
        int dNum = Convert.ToInt32(Console.ReadLine());
        circleList.RemoveAt(dNum - 1);
        Console.WriteLine("Circle removed.");
    }
    else if (option == 7)
    {
        circleList.Sort();
        foreach(var circles in circleList)
        {
            Console.WriteLine(circles.ToString() + $" Area: {circles.FindArea():F2}");
        }
    }
    else { Console.WriteLine("Invalid option"); }
}
static void InitCircleList(List<Circle> clist)
{
    Circle circle1 = new("Red", 20.0);
    Circle circle2 = new("Green", 10.0);
    Circle circle3 = new("Blue", 30.0);
    clist.Add(circle1);
    clist.Add(circle2);
    clist.Add(circle3);
}

static void DispMenu()
{
    Console.WriteLine("---------------- M E N U --------------------");
    Console.WriteLine("[1] List all the circles");
    Console.WriteLine("[2] Display the areas of the circles");
    Console.WriteLine("[3] Display the perimeters of the circles");
    Console.WriteLine("[4] Change the size of a circle");
    Console.WriteLine("[5] Add a new circle");
    Console.WriteLine("[6] Delete a circle");
    Console.WriteLine("[7] Display circles sorted by area");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------------------");
    Console.Write("Enter your option: ");
}