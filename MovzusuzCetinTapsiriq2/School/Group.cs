
namespace School
{
    internal class Group
    {
        public int GroupNo { get; }
        public int Limit { get; }
        private Student[] students;

        public Group(int groupNo, int limit)
        {
            GroupNo = groupNo;
            Limit = limit;
            students = new Student[Limit];
        }

        public void AddStudent(Student student)
        {
            for (int i = 0; i < Limit; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    return;
                }
            }
            Console.WriteLine("Group is full. Cannot add more students.");
        }

        public Student[] GetStudents()
        {
            return students;
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < Limit; i++)
            {
                if (students[i] == student)
                {
                    students[i] = null;
                    Console.WriteLine($"{student.Name} {student.Surname} is removed from the group.");
                    return;
                }
            }
            Console.WriteLine($"{student.Name} {student.Surname} is not in the group.");
        }
    }
}
