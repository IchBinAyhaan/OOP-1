using School;

class Program
{
    public static string Name { get; private set; }
    public static string Surname { get; private set; }

    public static void Main()
    {
        Student student1 = new Student(Name = "Ayhan", Surname = "Qasimli");
        Student student2 = new Student (Name = "Ali", Surname = "Veliyev");

        Group group = new Group(1, 2);
        group.AddStudent(student1);
        group.AddStudent(student2);

        Student[] students = group.GetStudents();
        Console.WriteLine("Students in the group:");
        foreach (var student in students)
        {
            if (student != null)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }
        }

        group.RemoveStudent(student1);
        group.RemoveStudent(new Student (Name = "Kanan", Surname = "Bayramli"));
    }
}