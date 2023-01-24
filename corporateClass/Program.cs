namespace corporateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Company
            Company FirstCompany = new Company();

            //Add 3 employees
            //Assign employees to company
        }
    }

    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

    }

    public class Employees { 

        // Create a private property for holding a collection of current employees
        private string employeeName { get; set; }

        private string jobTitle { get; set; }

        private DateTime startData { get; set; }

        List<Employees> employeesList = new List<Employees>();

        // Create a method that allows a caller to add an employee
        //AddEmployee() {}

        // Create a method that allows a caller to remove an employee
        //RemoveEmployee() {}


        // Create a method that allows a caller to retrieve the list of employees
        public void ListEmployees() 
        {
            foreach (Employees employee in employeesList)
            { 
            Console.WriteLine(@$"{employee.employeeName}
{employee.jobTitle}
{employee.startData}
=============================");
            }
        }


        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }
}
