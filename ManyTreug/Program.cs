
int xa = 10, ya = 10, xb = 20, yb = 20, xc = 15, yc = 15;
Console.SetCursorPosition(10, 10);
Console.WriteLine("+");

Console.SetCursorPosition(20, 20);
Console.WriteLine("+");

Console.SetCursorPosition(15, 15);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
while(count < 100000)
{
    int number = new Random().Next(0, 3);
    if (number == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
     if (number == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
     if (number == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count ++;
} 
