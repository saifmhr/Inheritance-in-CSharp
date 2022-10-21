using System;

//parents class
public class Employee
{
   public  string firstName;
   public string lastName;
   public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine(Email);
        Console.WriteLine();
    }
}


//derived class
public class FullTimeEmployee:Employee
{
  public  float YearlySalary;
}

//derived class
public class PartTimeEmployee : Employee
{
   public float Hourlyrate;
}

 class Program
    {
        static void Main()
        {
         
        FullTimeEmployee FTE=new FullTimeEmployee();
        FTE.firstName = "Saifullah";
        FTE.lastName = "Mahar";
        FTE.Email = "saifmahar165@gmail.com";
        FTE.YearlySalary = 300000;
        FTE.PrintFullName();


        PartTimeEmployee PTE=new PartTimeEmployee();
        PTE.firstName = "Aijaz";
        PTE.lastName = "Abro";
        PTE.Email = "Aijaz.134@gmail.com";
        PTE.Hourlyrate = 2000;
        PTE.PrintFullName();
        }
    }
