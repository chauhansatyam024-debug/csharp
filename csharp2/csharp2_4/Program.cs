using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp;

public class try2
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0) throw new ArgumentException("age cannot be negative ");
            age = value;
        }
        
    }

    public void start()
    {
        Console.WriteLine(age);
    }
}
public class try1
{
    public  string name { get; set; }
    public  int age { get; private set; }
    public try1(string name, int age)
    {
        name = name;
        age = age;
    }
    
}
public class Animal
{
    private string name;
    private int age;

    public Animal(string n, int a)
    {
        this.name = n; // coz we hv taken name and age as private ,  so we used this 
        this.age = a;
    }

    public void getName()
    {
        Console.WriteLine($"my pet  is {name} and age is {age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal ani = new Animal("cow",4);
        ani.getName();
        try1 t1 = new try1("satyam", 3);
        Console.WriteLine(t1.name ); // doesn't take the name we hv given ,  coz it is calling get set
        Console.WriteLine(t1.age); // same for this
        t1.name = "satyam"; // we hv to seperatrly give , during printing from outside of class
        Console.WriteLine(t1.name );
        try2 t2 = new try2();
        t2.Age = 4; // coz we set age = value in Age
        t2.start();
        t2.Age = -1; // we didn't use start coz , we hv already given throw new exception
        
        
    }
}
