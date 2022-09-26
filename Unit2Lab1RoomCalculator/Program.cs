// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the Room Detail Calculator!");

Console.WriteLine("Enter the length of one wall.");
double l = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the width of one wall.");
double w = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the height of one wall.");
double h = double.Parse(Console.ReadLine());

double area = l * w;
double peri = 2 * (l * w);
double vol = w * l * h;

Console.WriteLine("Length: {0} {1}Width: {2} {3}Height: {4} {5}Area: {6} {7}Perimeter: {8} {9}Volume: {10} {11}",

    l, Environment.NewLine,
    w, Environment.NewLine,
    h, Environment.NewLine,
    area, Environment.NewLine,
    vol, Environment.NewLine,
    peri, Environment.NewLine);

if (area <= 250)
{
    Console.WriteLine("This is a small room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This room is a medium room.");
}
else if (area >= 650)
{
    Console.WriteLine("This room is a large room.");
}

Console.WriteLine("Thank you for using the Room Detail Calculator.");


