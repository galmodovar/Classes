using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company a = new Company("Dollar General", new DateTime(2010, 08 , 13, 2, 0, 0));
            Employee rickySpanish = new Employee("Ricky", "Spanish", "Title 1", new DateTime(2011, 04, 17, 4, 3, 6));
            Employee lazloMorphine = new Employee("Lazlo", "Morphine", "Title 2", new DateTime(2012, 04, 17, 4, 3, 6));
            Employee kevinRammage = new Employee("Kevin", "Rammage", "Title 3", new DateTime(2013, 04, 17, 4, 3, 6));

            a.Employees.Add(rickySpanish);
            a.Employees.Add(lazloMorphine);
            a.Employees.Add(kevinRammage);

            a.ListEmployees();
        }
    }
}
