using InheritanceDemo26;

Console.WriteLine("Hello, World!");


Teacher t1 = new Teacher("Peter", "Vej 123", "Programming");
Secretary s1 = new Secretary("Ole", "Gade 123", 1000);



Console.WriteLine($"Salary teacher Programming {t1.CalculateSalary() }");

Employee e1 = new Teacher("Anne", "Alleen 2", "Mathematics");
//e1 = new Secretary("Kurt", "Gade 1222", 2323); 
Console.WriteLine($"Salary teacher Programming {e1.CalculateSalary()}");


List<Employee> allEmployees = new List<Employee>();

allEmployees.Add(t1);
allEmployees.Add(s1);
allEmployees.Add(e1);

foreach(Employee e in allEmployees)
{
    Console.WriteLine(e.CalculateSalary());
}