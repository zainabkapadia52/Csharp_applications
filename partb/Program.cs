using System;
    //user input and converting string to an integer
    Console.WriteLine("Enter the first number:");
    string input1= Console.ReadLine();
    int num1= Convert.ToInt32(input1);
    Console.WriteLine("Enter the second number:");
    string input2 = Console.ReadLine();
    int num2 = Convert.ToInt32(input2);
    logicPrgrm calc= new logicPrgrm(num1, num2);
    
    //performing operations
    int sum= calc.Add();
    int difference= calc.Subtract();
    int product= calc.Multiply();
    
    //if-else for Even/Odd
    string evenOrOdd;
    if (sum % 2 == 0){
        evenOrOdd = "Even";
    }else{
        evenOrOdd = "Odd";
    }
    Console.WriteLine("Results:- ");
    Console.WriteLine($"Addition: {sum} (The sum is {evenOrOdd})");
    Console.WriteLine($"Subtraction: {difference}");
    Console.WriteLine($"Multiplication: {product}");
    if(num2 == 0){
        Console.WriteLine("Division: Error! Cannot divide by zero.");
    }else{
        double ans= calc.Divide();
        Console.WriteLine($"Division: {ans:F2}"); 
    }