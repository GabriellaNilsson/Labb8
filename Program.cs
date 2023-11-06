using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1 - STACK
            
            // Objects 
            var E1 = new Employee(1, "Bob", "Male", 31000);
            var E2 = new Employee(2, "Claire", "Female", 27000);
            var E3 = new Employee(3, "John", "Male", 23000);
            var E4 = new Employee(4, "Vanessa", "Female", 22000);
            var E5 = new Employee(5, "Richard", "Male", 35000);

            // Stack class
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            // Printing all objects using Push-method
            Console.WriteLine("Push-method");
            foreach (var item in stack)
            {
                item.PrintInfo();
                Console.WriteLine($"Numbers of objects in stack: {stack.Count}");
            }
            Console.WriteLine("\n");

            // Pop-method
            Console.WriteLine("Pop-method");
            while (stack.Count > 0)
            {
                var stackItems = stack.Pop();
                stackItems.PrintInfo();
                Console.WriteLine($"Numbers of objects in stack: {stack.Count}");
            }
            Console.WriteLine("\n");

            // Add all items in stack again using Push-method

            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.WriteLine("Push-method again");
            foreach (var obj in stack)
            {
                obj.ShowInfo();
            }
            Console.WriteLine("\n");

            // Peek-method
            Console.WriteLine("Peek-method");

            Employee objectInStack = stack.Peek();
            Console.WriteLine($"Objekt 1 retived using Peek-method: Id: {objectInStack.ID}, Name: {objectInStack.Name}, Gender: {objectInStack.Gender}, Salary: {objectInStack.Salary}");
            Console.WriteLine($"Numbers of objects in stack: {stack.Count}");

            Employee objectInStack2 = stack.Peek();
            Console.WriteLine($"Objekt 2 retived using Peek-method: {objectInStack2.ID}, Name: {objectInStack2.Name}, Gender: {objectInStack2.Gender}, Salary: {objectInStack2.Salary}");
            Console.WriteLine($"Numbers of objects in stack: {stack.Count}");

            // Check if object number #3 is in stack
            Console.WriteLine("\nWe'll now check if object number 3 is in stack!");
            Employee employeeToFind = E3;
            if (stack.Contains(employeeToFind))
            {
                Console.WriteLine($"Yes, objekt number #{employeeToFind.ID} is in stack.");
            }

            else
            {
                Console.WriteLine($"No, objekt number #{employeeToFind.ID} is not in stack.");
            }


            // PART 2 - LIST

            // Creating an List<> and adding employees
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(E1);
            employeeList.Add(E2);
            employeeList.Add(E3);
            employeeList.Add(E4);
            employeeList.Add(E5);

            // Checking if object #2 is in List using Contains() method
            Console.WriteLine("\nWe'll now check if object #2 is in the list we created!");
            Console.WriteLine("Is object #2 in list?");
            Employee employeeToCheck = E2;

            if (employeeList.Contains(employeeToCheck))
            {
                Console.WriteLine("Yes, object #2 exists in the list");
            }

            else
            {
                Console.WriteLine("No, object #2 does not exist in the list");
            }

            // Using Find() method to find the first male employee in the list
            Console.WriteLine("\nLet's find and print the first male employee in the list");
            Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");

            if (firstMaleEmployee != null)
            {
                Console.WriteLine("First male employee in the list is:\n" + "ID: " +  firstMaleEmployee.ID + "\nName :" + firstMaleEmployee.Name + "\nSalary: " + firstMaleEmployee.Salary);
            }
            else
            {
                Console.WriteLine("No male employee found in the list.");
            }

            // Using FindAll() method to find all male employees in the list
            Console.WriteLine("\nLet's find and print all male employees in the list!");
            List<Employee> allMaleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
    
            foreach (var maleEmp in allMaleEmployees)
            {
                Console.WriteLine("All male employees:\n" + "ID: " + maleEmp.ID + "\nName :" + maleEmp.Name + "\nSalary: " + maleEmp.Salary);
            }
        }
    }
}