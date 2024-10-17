using Entities.EntitiesAbstract.Employee;

namespace Entities.Accounter
{
    public class Accounter : Employee
    {
        private Position _positionAccounter;
        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

         public enum Position
        {
            Junio,
            Master
        }


        public Accounter(string id, string name, int yearExprence, Position positionAccounter, int salary) : base(id, name, yearExprence)
        {
            _positionAccounter = positionAccounter;
            _salary = salary;
        }

        public override int Total()
        {
            if (YearExprence > 2) return Salary*1000;
            else {
                return Salary;
            }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("position: {0}", _positionAccounter);
            Console.WriteLine("Total salary: {0}", Total());
            Console.WriteLine();
        }
       


    }
}