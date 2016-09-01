{
  static void Main(string[]args)
  {
    Console.WriteLine("Please enter a number");
    var calcNumber1 = Convert.Toint32(Console.ReadLine());
    
    Console.WriteLine("Please enter a number");
    var calcNumber2 = Convert.Toint32(Console.ReadLine());
    
    Console.WriteLine("The sum is" + (calcNumber1 + calcNumber2));
    Console.WriteLine();
    
    var multSum = calcNumber1 * calcNumber2;
    Console.WriteLine("Multiplying these numbers gives you" + multSum);
    
    var difference = calcNumber1 - calcNumber2;
    Console.WriteLine("subtract first number from last number gives you" + difference);
    
    var division = Convert.ToDouble(calcNumber1)/Convert.ToDouble(calcNumber2);
    Console.WriteLine("divide a from b gives you" + division);
    
    Console.ReadLine();
    
  }
}
