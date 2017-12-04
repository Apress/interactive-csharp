using System;
class ClassA
{
    public int i;
    public ClassA()
    {
        this.i = 5;
        //this(5);//error
    }
    public ClassA(int i)
    {
        this.i = i;
    }

}
class ClassEx4
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** A Simple class with 2  different constructor ***");        
        ClassA obA = new ClassA();
        ClassA obB = new ClassA(75);
        Console.WriteLine("obA.i =" + obA.i);
        Console.WriteLine("obB.i =" + obB.i);
        Console.ReadKey();
    }
}
