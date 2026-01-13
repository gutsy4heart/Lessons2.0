//public class Calculator
//{
//    public double Add(double x, double y)
//    {
//        return x + y;
//    }
//    public static double Sub(double x, double y) 
//    {
//        return x - y; 
//    }
//    public double Multiply(double x, double y) 
//    {
//        return x * y; 
//    }
//    public double Divide(double x, double y)
//    {
//        if(y != 0)
//        {
//            return x / y;
//        }
//        throw new DivideByZeroException();
//    }

//}

//public delegate double CalcDelegate(double x, double y);

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Console.Write("Enter an expression: ");
//        string expression = Console.ReadLine() ?? "";
//        char sign = ' ';
//        foreach (char item in expression)
//        {
//            if(item == '+' || item =='-' || item == 
//                '*' || item == '/')
//            {
//                sign = item;
//                break;
//            }
//        }
//        try
//        {
//            string[] numbers = expression.Split(sign);
//            CalcDelegate del = null;
//            switch (sign)
//            {
//                case '+':
//                    del = new CalcDelegate(calculator.Add);
//                    break;
//                case '-':
//                    del = new CalcDelegate(Calculator.Sub);
//                    break;
//                case '*':
//                    del = new CalcDelegate(calculator.Multiply); 
//                    break;
//                case '/':
//                    del = calculator.Divide;
//                    break;
//                default:
//                    throw new InvalidOperationException();
//            }
//            Console.WriteLine($"Result: {del(double.Parse(numbers[0]), double.Parse(numbers[1]))}");
//        }

//        catch (Exception ex) 
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//}