using System.ComponentModel;
using System.Dynamic;
using Entities.EntitiesAbstract.Employee;

namespace Entities.developer
{


    public class Developer : Employee
    {
        private Position developerPosition;
        private int _salary;

        public enum Position
        {
            Backend,
            Fullstack,
            Frontend

        }

        private int Salary 
        {
            get {return _salary;}
            set {_salary = value;}
        }

        public Developer(string id, string name, int yearExprence, Position developerPosition, int salary) : base(id, name, yearExprence) 
        {
               this.developerPosition = developerPosition;
               _salary = salary; 
        }

        public override int Total()
        {
            if (YearExprence > 3) return Salary*300;
            else {
                return Salary;
            }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("position: {0}", developerPosition);
            Console.WriteLine("Total salary: {0}", Total());
            Console.WriteLine();
        }


    }
}