Person p1 = new Person();
Console.Write("Enter your FirstName: ");
p1.FirstName = Console.ReadLine();
Console.Write("Enter your LastName: ");
p1.LastName = Console.ReadLine();
Console.Write("Enter your Age: ");
p1.Age = int.Parse(Console.ReadLine());
Console.WriteLine();
p1.GetInfo();

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public void GetInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}\nLatName: {LastName}\nAge: {Age}");
    }
}

