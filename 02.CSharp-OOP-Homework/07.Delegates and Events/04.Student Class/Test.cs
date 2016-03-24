using System;

namespace _04.Student_Class
{
    class Test
    {
        static void Main()
        {
            Student student1=new Student("Gosho",15);
            Student student2=new Student("Niki",20);
            student1.OnPropertyChange+=PrintOnPropertyChange;
            student1.Name = "Bonka";
            student1.Age = 14;
            student2.OnPropertyChange += PrintOnPropertyChange;
            student2.Name = "Jibrito";
            student2.Age = 45;
        }

        private static void PrintOnPropertyChange(Student student, PropertyChangedEventArgs args)
        {
            Console.WriteLine("Property Changed: {0} (from {1} to {2})",args.PropertyName,args.OldValue,args.NewValue);
        }
    }
}
