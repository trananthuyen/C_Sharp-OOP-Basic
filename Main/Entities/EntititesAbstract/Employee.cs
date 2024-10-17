using System.Numerics;

namespace Entities.EntitiesAbstract.Employee
{
    public class Employee
    {
        private string _id;
        private string _name;
        private int _yearExprence;



        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int YearExprence
        {
            get { return _yearExprence; }
            set { _yearExprence = value; }
        }


        public Employee(string id, string name, int yearExprence)
        {
            _id = id;
            _name = name;
            _yearExprence = yearExprence;
        }


        public virtual int Total() {
            return 0;
        }

        public virtual void Display() {
            Console.WriteLine("id: {0}",Id);
            Console.WriteLine("name: {0}", Name);
            Console.WriteLine("Year experence: {0}", YearExprence);
        }
            
    }
}