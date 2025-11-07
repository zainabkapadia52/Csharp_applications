using System;
public class loopPrgrm
{
    //for loop
    public void RunForLoop(){
        Console.WriteLine("\nfor loop:-");
        for(int i=1;i<=10;i++){
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    //foreach loop 
    public void RunForEachLoop(){
        Console.WriteLine("\nforeach loop:-");
        int[] numbers= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int num in numbers){
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    //do-while loop
    public void RunDoWhileLoop(){
        Console.WriteLine("\ndo-while loop:- ");
        string input;
        do{
            Console.Write("Enter any text (or 'exit' to quit): ");
            input= Console.ReadLine()!;
        }
        while(input.ToLower()!= "exit");
        Console.WriteLine("Loop finished.");
    }
}