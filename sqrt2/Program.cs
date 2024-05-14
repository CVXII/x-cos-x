static double Sqrt(double x)
{
    if (x == 0) 
    {
        return 0;
    }

    double approximation = x; 
    double tolerance = 0.0001; 

    while (true)
    {
        double nextApproximation = 0.5 * (approximation + x / approximation); 
        if (Math.Abs(approximation - nextApproximation) < tolerance)
        {
            break; 
        }
        approximation = nextApproximation;
    }

    return approximation;
}


double number = 100;
double squareRoot = Sqrt(number);
Console.WriteLine("Квадратный корень из " + number + " = " + squareRoot);

