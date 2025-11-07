public class logicPrgrm{
    public int Number1{get; set;}
    public int Number2{get; set;}
    public logicPrgrm(int num1, int num2)
    {
        Number1= num1;
        Number2= num2;
    }
    public int Add()
    {
        return Number1 + Number2;
    }
    public int Subtract()
    {
        return Number1 - Number2;
    }
    public int Multiply()
    {
        return Number1 * Number2;
    }
    public double Divide()
    {
        if(Number2 == 0){
            return 0;
        }
        return (double)Number1 / Number2;
    }
}