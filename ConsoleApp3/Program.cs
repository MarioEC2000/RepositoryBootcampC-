// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Test");

string test = "DEFINE:A=TWO";
Console.WriteLine(test.Between("DEFINE:", "=")); // Output: A
Console.WriteLine(test.Between(":", "="));
//Comentario Test


MyClass clase = new MyClass();
clase.Show();

public static class TestString
{
    public static string Between(this string value, string a, string b)
    {
        int posA = value.IndexOf(a);
        int posB = value.LastIndexOf(b);
        if (posA == -1 || posB == -1 || posA + a.Length >= posB)
        {
            return string.Empty;
        }
        return value.Substring(posA + a.Length, posB - posA - a.Length);
    }
}

public class MyClass
{
    public void Display()
    {
        Console.WriteLine("Hello from MyClass!");
    }

    public void Show()
    {
        AnotherMethod(this); // Pasar la instancia actual
    }

    private void AnotherMethod(MyClass obj)
    {
        obj.Display();
    }
}
