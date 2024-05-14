double x0 = 0; 
double x;
do
{
    x = Math.Cos(x0); 
    x0 = x;
}
while (Math.Abs(x - x0) > 0.000001); 

Console.WriteLine("Решение уравнения: x = " + x);

