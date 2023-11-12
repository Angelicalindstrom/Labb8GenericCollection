using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;

namespace Labb8GenericCollection
{//Angelica Lindström .NET23
    internal class Program
    {
        static void Main(string[] args)
        { 
            Employee emp1 = new Employee(101, "Roland", "Male", 22000);
            Employee emp2 = new Employee(102, "Lisa", "Woman", 25000);
            Employee emp3 = new Employee(103, "Freddy", "Male", 20500);
            Employee emp4 = new Employee(104, "Maximus", "Male", 22600);
            Employee emp5 = new Employee(105, "Maria", "Woman", 23500);
            // created 5 objects from class Employee


            Stack<Employee> stack = new Stack<Employee>();
            // created a stack


            Console.WriteLine("Created a stack with Push\n\n");
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);
            //Pushed all the objects to stack Employee

            Console.WriteLine("\n*******************************\n");
            Console.WriteLine("The stack with all the Employees\n");


            foreach (var emp in stack)
            {
                Console.WriteLine($"ID: {emp.Id} Name: {emp.Name} Gender: {emp.Gender} Salary: {emp.Salary}");
            }
            Console.WriteLine($"\nNumber of Employees in the stack: {stack.Count}");
            // output all Employees with foreach


            Console.WriteLine("\n*******************************\n");
            Console.WriteLine("Using POP-method to write all the employees in the stack\n");

            while (stack.Count != 0 )
            {
               stack.Pop();
                
                foreach (var emp in stack)
                {
                    Console.WriteLine($"ID: {emp.Id} Name: {emp.Name} Gender: {emp.Gender} Salary: {emp.Salary}");
                }

                Console.WriteLine($"Number of Employees in the stack: {stack.Count}\n");
                if (stack.Count == 0)
                {
                    Console.WriteLine("\nThe stack is now empty, no employees left");
                }
                
            }// pop Method to get output of all the Employyes in the stack and to see how many there´s left in the stack


            Console.WriteLine("\n*******************************\n");
            Console.WriteLine("Creating the stack again with Push\n");


            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Using PEEK TO retrive 2 Employees in the stack \n");
            // push all the objects back in the stack.
            

            foreach (var emp in stack)
            {
                stack.Peek();
                Console.WriteLine($"ID: {emp.Id} Name: {emp.Name} Gender: {emp.Gender} Salary: {emp.Salary}");
                Console.WriteLine($"Number of Employees in the stack: {stack.Count}\n");
                if (emp == emp4)
                {
                    break;
                }

            } // Peek method to watch every object in the stack + numbjer of Employees left in the stack

            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Looking if Employee Nr 3 still is in the stack \n");

            if (stack.Contains(emp3))
            {
                Console.WriteLine("Employee Nr3 is still in stack.");
                Console.WriteLine($"ID: {emp3.Id} Name: {emp3.Name} Gender: {emp3.Gender} Salary: {emp3.Salary}");
            } // Contains metod, looking if Emp3 is still in stack with an Ifstatement


            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Creating a List and write all the employees in the List \n");

            var empList = new List <Employee>() { emp1, emp2, emp3, emp4, emp5 };
            // New list, using the same objects as in the stack


            foreach (var emp in empList)
            {
                Console.WriteLine($"ID: {emp.Id} Name: {emp.Name} Gender: {emp.Gender} Salary: {emp.Salary}\n");

            } // Foreachloop to show all employees in List


            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Using Contains() in EmployeeList to check if object 2(Employee nr 2) is still in the list\n");


            if (empList.Contains(emp2))
            {
                Console.WriteLine($"Employee2 object exist in the list");
                Console.WriteLine($"ID: {emp2.Id} Name: {emp2.Name} Gender: {emp2.Gender} Salary: {emp2.Salary}\n");
            }
            else
            {
                Console.WriteLine($"Employee2 object does not exist in the list");
            }// Using Contain with If, else to see if employee nr 2 exists in the list

            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Using Find() in EmployeeList to find the first object that´s an male\n");


            Employee findNr1Male = empList.Find(x => x.Gender == "Male");
            Console.WriteLine($"ID: {findNr1Male.Id} Name: {findNr1Male.Name} Gender: {findNr1Male.Gender} Salary: {findNr1Male.Salary}\n");
            // Using Find to se who´s the first Male in the list.


            Console.WriteLine("\n*******************************\n");
            Console.WriteLine($"Using FindAll() in EmployeeList to find all Male Objects in the list\n");



            List<Employee> filteredEmployees = empList.FindAll(emp => emp.Gender == "Male");
            foreach (Employee findAllMales in filteredEmployees)
            {
                Console.WriteLine($"ID = {findAllMales.Id}, Name = {findAllMales.Name}, Gender = {findAllMales.Gender}, Salary = {findAllMales.Salary}");
            } // FindAll to find all Males in the list. foreach loop to get the output of all Males in the list.



            Console.ReadKey();

        }
    }
}