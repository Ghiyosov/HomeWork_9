using Domein.Models;

namespace Infrastructure.Services;

public class CourseService
{
     public List<Course> courses = new List<Course>();

    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCource(Course course)
    {
        if (course.Id==0)
        {
            course.Id = courses.Count + 1;
        } 
        courses.Add(course);
        System.Console.WriteLine($"Course {course.Title} is add");
    }
    public void UpdateCourse(Course course)
    {
        if(course.Id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var st in courses)
        {
            if(st.Id == course.Id)
            {
                st.Title = course.Title;
                st.Description = course.Description;
                st.Free = course.Free;
                st.HasDiscount = course.HasDiscount;
                
                System.Console.WriteLine($"Course {st.Title} is update");
                return;
            }

        }
    }
    public void DeleteCourse(int id)
    {
         if(id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var stu in courses)
        {
            if (stu.Id == id)
            {
                courses.Remove(stu);
                System.Console.WriteLine($"Student {stu.Title} is delete");
                return;
            }
        }
    }
}

