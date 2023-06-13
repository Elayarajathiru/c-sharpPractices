using System;

class baseClass

{
    public void show()
    {
        Console.WriteLine("Base class");
    }
}

class derivedClass : baseClass
{

    // overriding in derived class
    new public void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG
{
    public static void Main()
    {
        baseClass obj = new baseClass();
        obj.show();
        obj = new derivedClass();
        obj.show();

        derivedClass d = new derivedClass();
        d.show();
        Console.ReadLine();

    }
}
