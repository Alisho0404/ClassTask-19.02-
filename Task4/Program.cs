 var employee=new Employee();
Console.Write("Enter employee's FirstName: ");
employee.FirsName = Console.ReadLine();
Console.Write("Enter employee's LastName: ");
employee.LastName = Console.ReadLine();
Console.Write("Enter employee's Age: "); 
employee.Age=int.Parse(Console.ReadLine());
Console.Write("Enter employee's Position: ");
employee.Position = Console.ReadLine();
Console.Write("Enter employee's Salary: ");
employee.Salary=int.Parse(Console.ReadLine());
Console.WriteLine();  

employee.GetInfo();
Console.WriteLine(); 

Console.Write($"Set a new Salary: ");
decimal salary = decimal.Parse(Console.ReadLine());
employee.SetSalary(salary); 

Console.WriteLine();
Console.WriteLine(employee.GetInfo());



class Employee
{
    public string FirsName;
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;
    public void SetSalary(decimal salary) 
    { 
        Salary = salary;
    }
     
    public decimal GetSalary()
    {
        return Salary;
    }

    public string GetInfo()
    {
        return $"FirstName: {FirsName}\nLastName: {LastName}\nAge: {Age}\n" +
             $"Position: {Position}\nSalary: {Salary}";
    }
}