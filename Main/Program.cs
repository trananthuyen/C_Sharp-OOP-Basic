// See https://aka.ms/new-console-template for more information



using Entities.Accounter;
using Entities.developer;
using Entities.EntitiesAbstract.Employee;
using ListEmployee.ListOfEmployee;

namespace Main.Program
{
   
   public class Run
   {
        public static void Main(string[] args){
            ListEmployes list = new ListEmployes();


            list.InputData();
            
            Console.WriteLine(" Display list: ");
            list.Display2();
        }
   }

}
