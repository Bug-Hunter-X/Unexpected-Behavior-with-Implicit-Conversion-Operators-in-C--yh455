public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int num = obj1;   // Implicit conversion from MyClass to int

        Console.WriteLine(num); // Output: 5

        MyClass obj2 = new MyClass(10);
        int num2 = obj2 + 5; // Implicit conversion, addition, and implicit conversion again.  This may not always work as expected
        Console.WriteLine(num2); // Output: 15

        MyClass obj3 = obj2 + 5; //Implicit Conversion, addition, and implicit conversion again.
        Console.WriteLine(obj3.MyProperty); //Output: 15
    }
}