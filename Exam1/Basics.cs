using System.Security.Cryptography.X509Certificates;

namespace Exam1;

public class Q1_Add{
    public static int Add(int a, int b){
        return a + b;
    }
}
public class Basics{
    public static void Q2MultiplyAndReset(ref int a,ref int b){
        a = a*b;
        b = 1;
    }
    public static void Q5TryCatchFinally(bool shouldthrow, List<string> report, bool caught){
        if (shouldthrow){
            throw new InvalidOperationException();
        }
    }
    public static void Q5TryCatchFinally(bool shouldthrow, List<string> report){
        if (shouldthrow){
            report.Add("Try");
            report.Add("Catch");
            report.Add("Finally");
        }
        else{
            report.Add("Try");
            report.Add("AfterTry");
            report.Add("Finally");
        }
    }
}


public class Type1{
    public int Count;
}
public class Type2{
    public int Count;
}


public class Q4Person{
    public string Name;
    public int Age;
    public Q4Person(string name, int age){
        this.Name = name;
        this.Age = age;
    }
    public string Introduce(){
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Q6Temperature{
    private double celsius;
    public double Celsius{
        get{
            return celsius;// (32-fahrenheit)*(5/9);
        }
        set{
            celsius = value;
            fahrenheit = (celsius*(1.8))+32;
        }
    }
    private double fahrenheit;
    public double Fahrenheit{
        get{
            return fahrenheit;//32+(celsius*(9/5));
        }
        set{
            fahrenheit = value;
            celsius = (fahrenheit-32)*(0.5555555555556);
        }
    }
}
public interface IShape{
    public double GetArea();
    public double GetPerimeter();
}
public class Q7Circle : IShape{
    public double Radius;
    public Q7Circle(double rad){
        this.Radius = rad;
    }
    public double GetArea(){
        return Math.PI * Radius * Radius;
    }
    public double GetPerimeter(){
        return Math.PI * 2 * Radius;
    }
}
public class Q7Rectangle : IShape{
    public double width;
    public double height;
    public Q7Rectangle(double wid, double hei){
        this.width = wid;
        this.height = hei;
    }
    public double GetArea(){
        return width * height;
    }
    public double GetPerimeter(){
        return 2 * (width + height);
    }
}
public class ShapeUtils{
    public static double Q7TotalArea(IShape[] shapes){
        double sumarea = 0;
        for (int i = 0; i < shapes.Length; i++){
            sumarea += shapes[i].GetArea();
        }
        return sumarea;
    }
}