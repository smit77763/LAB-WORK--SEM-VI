using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18jan2022
{
    class SelectionSorter
    {
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparision(sortArray[i], sortArray[i + 1]))   //element comparision true or false  1 or 0 -1
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

    }
        public enum Designations
        {
           CEO=5,
           CFO=4,
           sde=2,
           ba=1,
           pm=3
        }

        class Employee
        {
            int empid;
           public  float salary;
            public string name;
           public  Designations designation;

            public Employee(int EmpId, float Salary, string NAme, Designations design)
            {
                this.empid = EmpId;
                this.salary = Salary;
                this.name = NAme;
                this.designation = design;

            }

           internal static bool CompareSalary(Employee e1, Employee e2)
            {
                return e1.salary < e2.salary;
            }

           internal static bool CompareNames(Employee e1, Employee e2)
            {
                if(e1.name.CompareTo(e2.name)== 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

           internal static bool CompareDesignations(Employee e1, Employee e2)
            {
                return e1.designation < e2.designation;
            }
        }
    

    public class TestGenericMethods
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>(30);
            emplist.Add(new Employee(5, 5000000, "SMIT", Designations.CEO)); 

            emplist.Add(new Employee(8, 1200000, "HASRH", Designations.CFO));

            emplist.Add(new Employee(1, 25000, "KUSH", Designations.sde));
            emplist.Add(new Employee(3, 15000, "satvan", Designations.pm));


            SelectionSorter.Sort<Employee>(emplist, Employee.CompareDesignations);
           Console.WriteLine("Employee Name    Designation");
            foreach(Employee e1 in emplist)
            {
                Console.WriteLine(e1.name+"                 "+e1.designation);
            }

            SelectionSorter.Sort<Employee>(emplist, Employee.CompareSalary);
            Console.WriteLine("\nEmployee Name       Salary      Designation");
              foreach(Employee e1 in emplist)
            {
                Console.WriteLine(e1.name+"                 "+e1.salary+"     "+e1.designation);
            }

        }
    }
}
