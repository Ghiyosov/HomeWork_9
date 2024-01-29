using Domein.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    public List<Teacher> teachers = new List<Teacher>();

    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        if (teacher.Id==0)
        {
            teacher.Id = teachers.Count + 1;
        } 
        teachers.Add(teacher);
        System.Console.WriteLine($"Techer {teacher.FirstName} is add");

    }
    public void UpdateTeacher(Teacher teacher)
    {
        if(teacher.Id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var st in teachers)
        {
            if(st.Id == teacher.Id)
            {
                st.FirstName = teacher.FirstName;
                st.Lastname = teacher.Lastname;
                st.BirthDate = teacher.BirthDate;
                st.Address = teacher.Address;
                System.Console.WriteLine($"Techer {st.FirstName} is update");
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
        foreach (var stu in teachers)
        {
            if (stu.Id == id)
            {
                teachers.Remove(stu);
                System.Console.WriteLine($"Teacher {stu.FirstName} is delete");
                return;
            }
        }
    }
}
