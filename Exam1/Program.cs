namespace Exam1;

class Program
{
    static void Main(string[] args)
    {
        var temp = new Q6Temperature();
        temp.Celsius = -40.0;
        System.Console.WriteLine(temp.Fahrenheit);
        System.Console.WriteLine(temp.Celsius);
    }
}
