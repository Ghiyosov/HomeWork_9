




using Domein.Models;
using Infrastructure.Services;

var student1 = new Student();
student1.FirstName = "Ismoil";
student1.Lastname = "Ghiyosov";
student1.BirthDate = new DateTime(2001,02,20);
student1.Address = "Mushfiqi";
var student2 = new Student();
student2.FirstName = "Abdullo";
student2.Lastname = "Abdulloev";
student2.BirthDate = new DateTime(2007,09,01);
student2.Address = "Shamsi";
var student3 = new Student();
student3.FirstName = "Musso";
student3.Lastname = "Mussoev";
student3.BirthDate = new DateTime(2006,03,09);
student3.Address = "Borbad";

var studentSer1 = new StudentService();
studentSer1.AddStudent(student1);
studentSer1.AddStudent(student2);
studentSer1.AddStudent(student3);
System.Console.WriteLine("*********************************************");
foreach(var ser in studentSer1.GetStudents())
{
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine(ser.Id);
    System.Console.WriteLine(ser.FirstName);
    System.Console.WriteLine(ser.Lastname);
    System.Console.WriteLine(ser.BirthDate);
    System.Console.WriteLine(ser.Address);
}
var student4 = new Student();
student4.Id = 2;
student4.FirstName = "Abdulloboy";
student4.Lastname = "Abdulloev";
student4.BirthDate = new DateTime(2007,09,01);
student4.Address = "Shamsidin";
studentSer1.UpdateStudent(student4);
studentSer1.Delete(3);
foreach(var ser in studentSer1.GetStudents())
{
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine(ser.Id);
    System.Console.WriteLine(ser.FirstName);
    System.Console.WriteLine(ser.Lastname);
    System.Console.WriteLine(ser.BirthDate);
    System.Console.WriteLine(ser.Address);
}





var teacher1 = new Teacher();
teacher1.FirstName = "Ismoil";
teacher1.Lastname = "Ghiyosov";
teacher1.BirthDate = new DateTime(2001,02,20);
teacher1.Address = "Mushfiqi";
var teacher2 = new Teacher();
teacher2.FirstName = "Abdullo";
teacher2.Lastname = "Abdulloev";
teacher2.BirthDate = new DateTime(2007,09,01);
teacher2.Address = "Shamsi";
var teacher3 = new Teacher();
teacher3.FirstName = "Musso";
teacher3.Lastname = "Mussoev";
teacher3.BirthDate = new DateTime(2006,03,09);
teacher3.Address = "Borbad";

var teachertSer1 = new TeacherService();
teachertSer1.AddTeacher(teacher1);
teachertSer1.AddTeacher(teacher2);
teachertSer1.AddTeacher(teacher3);
System.Console.WriteLine("*********************************************");
foreach(var ser in teachertSer1.GetTeachers())
{
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine(ser.Id);
    System.Console.WriteLine(ser.FirstName);
    System.Console.WriteLine(ser.Lastname);
    System.Console.WriteLine(ser.BirthDate);
    System.Console.WriteLine(ser.Address);
}
var teacher4 = new Teacher();
teacher4.Id = 2;
teacher4.FirstName = "Abdulloboy";
teacher4.Lastname = "Abdulloev";
teacher4.BirthDate = new DateTime(2007,09,01);
teacher4.Address = "Shamsidin";
teachertSer1.UpdateTeacher(teacher4);
teachertSer1.Delete(3);
foreach(var ser in teachertSer1.GetTeachers())
{
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine(ser.Id);
    System.Console.WriteLine(ser.FirstName);
    System.Console.WriteLine(ser.Lastname);
    System.Console.WriteLine(ser.BirthDate);
    System.Console.WriteLine(ser.Address);
}

System.Console.WriteLine("******************************************");

var post = new Post();
post.Title = "Kitob";
post.Description = "Sarlavha";
post.VoitAmount = 3;
post.CreatedAl = new DateTime (2006,08,12);

var post1 = new Post();
post1.Title = "Kitob1";
post1.Description = "Sarlavha1";
post1.VoitAmount = 3;
post1.CreatedAl = new DateTime (2006,08,12);

var post2 = new Post();
post2.Title = "Kitob2";
post2.Description = "Sarlavha2";
post2.VoitAmount = 3;
post2.CreatedAl = new DateTime (2006,08,12);

var postSer = new PostService();
postSer.AddPost(post);
postSer.AddPost(post1);
postSer.AddPost(post2);
foreach (var po in postSer.GetPosts())
{
    System.Console.WriteLine("--------------------------------");
    System.Console.WriteLine(po.Title);
    System.Console.WriteLine(po.Description);
    System.Console.WriteLine(po.VoitAmount);
    System.Console.WriteLine(po.CreatedAl);   
}
var post3 = new Post();
post3.Id = 2;
post3.Title = "Kitob28";
post3.Description = "Sarlavha2";
post3.VoitAmount = 3;
post3.CreatedAl = new DateTime (2006,08,12);
postSer.UpdatePost(post3);
postSer.DeletePost(3);
foreach (var po in postSer.GetPosts())
{
    System.Console.WriteLine("--------------------------------");
    System.Console.WriteLine(po.Title);
    System.Console.WriteLine(po.Description);
    System.Console.WriteLine(po.VoitAmount);
    System.Console.WriteLine(po.CreatedAl);   
}

var course = new Course();
course.Title = "C++";
course.Description = "learn";
course.Free = 1000m;
course.HasDiscount = true;

var course1 = new Course();
course1.Title = "C#";
course1.Description = "learn";
course1.Free = 1000m;
course1.HasDiscount = true;

var course2 = new Course();
course2.Title = "Js";
course2.Description = "learn";
course2.Free = 1500m;
course2.HasDiscount = true;

var courseSer = new CourseService();
courseSer.AddCource(course);
courseSer.AddCource(course1);
courseSer.AddCource(course2);

System.Console.WriteLine("***************************************");
foreach (var co in courseSer.GetCourses())
{
    System.Console.WriteLine("-------------------------------------------------");
    System.Console.WriteLine(co.Id);
    System.Console.WriteLine(co.Title);
    System.Console.WriteLine(co.Description);
    System.Console.WriteLine(co.Free);
    System.Console.WriteLine(co.HasDiscount);
}
var course3 = new Course();
course3.Id = 2;
course3.Title = "C#";
course3.Description = "learn";
course3.Free = 1500m;
course3.HasDiscount = true;
System.Console.WriteLine("***********************");
courseSer.UpdateCourse(course3);
courseSer.DeleteCourse(3);
foreach (var co in courseSer.GetCourses())
{
    System.Console.WriteLine("-------------------------------------------------");
    System.Console.WriteLine(co.Id);
    System.Console.WriteLine(co.Title);
    System.Console.WriteLine(co.Description);
    System.Console.WriteLine(co.Free);
    System.Console.WriteLine(co.HasDiscount);
}