using System.Data.Common;
using Domein.Models;

namespace Infrastructure.Services;

public class StudentService
{
    public List<Student> students = new List<Student>();

    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        if (student.Id==0)
        {
            student.Id = students.Count + 1;
        } 
        students.Add(student);
        System.Console.WriteLine($"Student {student.FirstName} is add");
    }
    public void UpdateStudent(Student student)
    {
        if(student.Id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var st in students)
        {
            if(st.Id == student.Id)
            {
                st.FirstName = student.FirstName;
                st.Lastname = student.Lastname;
                st.BirthDate = student.BirthDate;
                st.Address = student.Address;
                System.Console.WriteLine($"Student {st.FirstName} is update");
                return;
            }

        }
    }
    public void Delete(int id)
    {
         if(id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var stu in students)
        {
            if (stu.Id == id)
            {
                students.Remove(stu);
                System.Console.WriteLine($"Student {stu.FirstName} is delete");
                return;
            }
        }
    }
}
