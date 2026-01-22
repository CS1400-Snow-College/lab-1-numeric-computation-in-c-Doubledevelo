// Mathematics

void workWithIntegers()
{
int a = 18;
int b = 6;

int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c = a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);

c = a + b - 12 * 17;
Console.WriteLine(c);
};

//workWithIntegers();

void orderOfOperations()
{
    int a = 5;
    int b = 4;
    int c = 2;

    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d =(a + b) - 6 * c + (12 * 4)/3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    
    int h = (e + f) / g;
    Console.WriteLine(h);
};

//orderOfOperations();

void integerPrecision()
{
    int a = 7;
    int b = 4;
    int c = 3;
    
    int d = (a + b)/c;
    int e = (a + b)%c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
};

//integerPrecision();

void workWithDoubles()
{
  double a = 5;
  double b = 4;
  double c = 2;
  double d = (a + b)/c;
  Console.WriteLine(d);

  a = 76;
  b = 203;
  c = 14;
  d = (a + b) / c;
  Console.WriteLine(d);
  
  double max = double.MaxValue;
  double min = double.MinValue;
  Console.WriteLine($"The range of double is {min} to {max}");

  double third = 1.0/3.0;
  Console.WriteLine(third);
};

//workWithDoubles();

void workWithDecimal()
{
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a/b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c/d);

};

//workWithDecimal();

void calculateCircleArea(double radius)
{
    Console.WriteLine($"Radius of circle is {radius}");
    double area = Math.PI * Math.Pow(radius,2.0);
    Console.WriteLine($"Area of circle is {area}");
    // just for fun
    double circumfrence = 2.0*Math.PI*radius;
    Console.WriteLine($"Circumfrence of circle is {circumfrence}");
}
;

calculateCircleArea(2.5);
//calculateCircleArea(4.7);