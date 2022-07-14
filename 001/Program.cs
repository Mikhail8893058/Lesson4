// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите B: ");
double B = Convert.ToDouble(Console.ReadLine());

double degree = 0;
double result = 0;

double n = A;
if(B < 0)
{
  degree = B *(-1);
}
else
{
  degree = B;
}

for(double count = 1; count < degree; count++ )
{
  
  if(B > 0)
  {
  n = n * A;
  result = n;
  }
  else
  {
    n = n * A;
    result = 1 / n;
  }
} 
Console.WriteLine(result);



// Console.WriteLine("Введите A: ");
// double A = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите B: ");
// double B = Convert.ToDouble(Console.ReadLine());


// double result = 0;

// double n = A;


// for(double count = 1; count < Math.Abs(B); count++ )
// {
  
//   if(B > 0)
//   {
//   n = n * A;
//   result = n;
//   }
//   else
//   {
//     n = n * A;
//     result = 1 / n;
//   }
// } 
// Console.WriteLine(result);





// Console.WriteLine("Введите число:");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень для числа:");
// double b = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(a, b);
// Console.WriteLine(result);