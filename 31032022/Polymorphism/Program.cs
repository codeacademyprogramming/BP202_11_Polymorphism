using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Hikmet";
            student.Surname = "Abbasov";
            student.GroupNo = "P123";

            Human human = new Human();
            human.Name = "Nermin";
            human.Surname = "Abdullazade";
            human = student;

            student.ShowInfo();
            human.ShowInfo();

            WarrantyStudent warrantyStudent = new WarrantyStudent();
            warrantyStudent.OldGroupNo = "P122";
            warrantyStudent.GroupNo = "P223";
            warrantyStudent.Name = "Nermine";
            warrantyStudent.Surname = "Abbasova";

            Human human1 = warrantyStudent;
            human1.ShowInfo();
           
            human1.ShowInfo();

            student = warrantyStudent;
            student.ShowInfo();





            Store store = new Store();
            store.Products = new Product[] {
                new Notebook {Price = 4500 },
                new Phone{Price= 3200},
                new HeadPhone{Price = 150},
                new SmartWatch{Price = 400},
                new TV{Price = 5000},
            };

            Console.WriteLine(store.CalcAllPrice());

        }
    }
}
