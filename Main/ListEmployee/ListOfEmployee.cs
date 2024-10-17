using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Numerics;
using Entities.Accounter;
using Entities.developer;
using Entities.EntitiesAbstract.Employee;

namespace ListEmployee.ListOfEmployee
{
    public class ListEmployes
    {
        List<Employee> employees = new List<Employee>();

        public ListEmployes()
        {

        }

        public void InputDataDeveloper()
        {
            Console.WriteLine("Input information of developer:");
            Console.WriteLine("input id: ");
            string id = Console.ReadLine() ?? "";
            Console.WriteLine("input name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("input exprence: ");
            int yearExprence = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("choose the position: 1.backend, 2.frontend 3.fullstack: ");
            int choose2 = Convert.ToInt16(Console.ReadLine());

            Developer.Position positionChoose;

            if (choose2 == 1)
            {
                positionChoose = Developer.Position.Backend;
            }
            else if (choose2 == 2)
            {
                positionChoose = Developer.Position.Frontend;
            }
            else
            {
                positionChoose = Developer.Position.Fullstack;
            }

            Console.WriteLine("input salary: ");
            int salary = Convert.ToInt16(Console.ReadLine());
            employees.Add(new Developer(id, name, yearExprence, positionChoose, salary));
        }

        public void InputDataAccounter() {
            Console.WriteLine("Input information of accounter:");
            Console.WriteLine("input id: ");
            string id = Console.ReadLine() ?? "";
            Console.WriteLine("input name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("input exprence: ");
            int yearExprence = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("choose the position: 1.Junio, 2.Master ");
            int choose2 = Convert.ToInt16(Console.ReadLine());

            Accounter.Position positionChoose;

            if (choose2 == 1)
            {
                positionChoose = Accounter.Position.Junio;
            }
            else
            {
                positionChoose = Accounter.Position.Master;
            }
          

            Console.WriteLine("input salary: ");
            int salary = Convert.ToInt16(Console.ReadLine());
            employees.Add(new Accounter(id, name, yearExprence, positionChoose, salary));
        }

        public void InputData()
        {
            Console.WriteLine("input number Employee: ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("choose 1. Developer, 2.Accounter: ");
                int choose = Convert.ToInt16(Console.ReadLine());

                if (choose == 1)
                {
                   Console.WriteLine("index: {0}", i+1);
                   InputDataDeveloper();
                } else {
                   Console.WriteLine("index: {0}", i+1);
                   InputDataAccounter();
                }
            }

        }

        public void Display()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].Display();
            }

        }

        public void Display2()
        {
            foreach (var i in employees)
            {
                i.Display();
            }
        }

    }
}