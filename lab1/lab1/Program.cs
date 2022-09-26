
Console.Write("Enter the value of length : ");
decimal Length = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter the value of width : ");
decimal Width = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter the value of height: ");
decimal Height = Convert.ToDecimal(Console.ReadLine());
decimal Perimeter = 2 * (Length + Width);
Console.Write("The Perimeter of Rectangle is: " + Perimeter);
Console.ReadLine();
decimal volume = (Length * Width * Height);
Console.WriteLine("The volume of the rectangle is: " + volume);
decimal area = (Length * Width);
Console.WriteLine("The area of the regtangle is: " + area);
if (area <= 250)  Console.WriteLine("The room is small");
if (area > 250 && area < 650) Console.WriteLine("The room is medium");
if (area > 650)  Console.WriteLine("The room is large");

