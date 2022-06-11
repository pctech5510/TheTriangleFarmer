// See https://aka.ms/new-console-template for more information
float bottom;
float height;
float area;

Console.WriteLine("Welcome! I will find the area of a triangle for you\n");
Console.WriteLine("What is the base?");
bottom = float.Parse(Console.ReadLine());
Console.WriteLine("What is the height?");
height = float.Parse(Console.ReadLine());

area = (bottom * height) / 2;


Console.WriteLine("The bottom is\n" + bottom);
Console.WriteLine("the height is\n" + height);
Console.WriteLine("The area is " + area);



