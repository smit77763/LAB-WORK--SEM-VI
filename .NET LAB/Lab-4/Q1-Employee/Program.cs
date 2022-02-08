
namespace Program
{

    class MainClass
    {

        public static void Main(String[] argv)
        {

            EmployeeData.Employee employee1 = new EmployeeData.Employee("Smit", "Shah", 100000.00);
            EmployeeData.Employee employee2 = new EmployeeData.Employee("Harsh", "Patel", 250000.00);

            //details of employee 1 & employee 2
            Console.WriteLine("-----------Yearly Salary Of Employees----------- \n");
            Console.WriteLine($"-------First Employee-------  \nYearly Salary : Rs.{employee1.MonthlySalary * 12}");
            Console.WriteLine($"-------Second Employee------- \nYearly Salary : Rs.{employee2.MonthlySalary * 12}");


            //giving 10% raise to employee
            employee1.getRaise(10);
            employee2.getRaise(10);

            Console.WriteLine("\n-----------Yearly Salary Of Employees After Giving 10%Raise-----------\n");
            Console.WriteLine($"-------First Employee-------  \n\nYearly Salary : {employee1.MonthlySalary * 12}");
            Console.WriteLine($"-------Second Employee------- \n\nYearly Salary : {employee2.MonthlySalary * 12}");


            //permanent Employees Derived Class
            EmployeeData.PermanentEmployee permanentEmployee1 = new EmployeeData.PermanentEmployee("Smit", "Shah", 100000.00, "14-02-2022", "20-12-2032");
            EmployeeData.PermanentEmployee permanentEmployee2 = new EmployeeData.PermanentEmployee("Harsh", "Patel", 250000.00, "14-02-2022", "06-12-2042");
            Console.WriteLine("\n\n-----------For Permanent Employees-----------");
            Console.WriteLine("\n-------Details Of Permanent Employee 1-------\n");
            Console.WriteLine(permanentEmployee1);
            Console.WriteLine("\n-------Details Of Permanent Employee 2-------");
            Console.WriteLine(permanentEmployee2);

            //giving 20% raise
            permanentEmployee1.getRaise(20);
            permanentEmployee2.getRaise(20);


            Console.WriteLine("\n\n-----------After Giving 20% Raise-----------");
            Console.WriteLine("\n-------Details Of Permanent Employee 1-------\n");
            Console.WriteLine(permanentEmployee1);
            Console.WriteLine("\n-------Details Of Permanent Employee 2-------");
            Console.WriteLine(permanentEmployee2);



        }
    }
}
