using System;
Console.Write("Enter a number to calculate its factorial: ");
string input= Console.ReadLine()!;
int num= Convert.ToInt32(input);

long ans= facto(num);
Console.WriteLine($"The factorial of {num} is {ans}.");
loopPrgrm fact= new loopPrgrm();
fact.RunForLoop();    
fact.RunForEachLoop(); 
fact.RunDoWhileLoop();

//static function to calculate factorial
static long facto(int n){
    if(n<0){
        Console.WriteLine("Factorial is not defined for negative numbers.");
        return -1;
    }
    if(n==0||n==1){
        return 1;
    }
    long res= 1;
    for(int i=2;i<=n;i++){
        res= res* i;
    }
    return res;
}