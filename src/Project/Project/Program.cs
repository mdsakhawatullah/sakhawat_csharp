using Project;
using System.Reflection;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Provide user name and password");
            Console.Write("username: ");
            string username = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();

            TrainingDbContext dbContext = new TrainingDbContext();

           User? userLogin = dbContext.Users.Where(x=> x.UserName==username && x.Password==password).FirstOrDefault();
           UserTeacher? teacherLogin = dbContext.Teachers.Where(x=> x.TeacherName == username && x.Password==password).FirstOrDefault();

    

            if (userLogin != null && teacherLogin == null)
            {
                Console.WriteLine("Admin login  successful");

                while (true)
                {

                    Console.WriteLine("1. Insert data");
                    Console.WriteLine("2. Edit data");
                    Console.WriteLine("3. Delete data");
                    Console.WriteLine("4. View data");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            //insert
                            Classroom classroom = new Classroom();
                            Console.Write("Enter className: ");
                            classroom.ClassName = Console.ReadLine();
                            Console.Write("Enter SubjectName: ");
                            classroom.SujectName = Console.ReadLine();
                            Console.Write("Enter teacherName: ");
                            classroom.TeacherName = Console.ReadLine();



                            dbContext.Classrooms.Add(classroom);
                            dbContext.SaveChanges();
                            break;
                        case "2":
                            //edit
                            Console.Write("Enter the name to edit ClassName/SujectName/TeacherName: ");
                            string propertyName = Console.ReadLine();

                            Console.Write("Enter the data for search: ");
                            string targetValue = Console.ReadLine();

                            PropertyInfo property = typeof(Classroom).GetProperty(propertyName);

                            if (property != null)
                            {

                                var allClassrooms = dbContext.Classrooms.ToList();

                                // filter records dynamic property
                                var classrooms = allClassrooms.FirstOrDefault(c => property.GetValue(c).ToString() == targetValue);

                                if (classrooms != null)
                                {
                                    // edit
                                    Console.Write("Enter the new value for the property: ");
                                    string newValue = Console.ReadLine();

                                    // using reflection
                                    property.SetValue(classrooms, newValue);

                                    dbContext.SaveChanges();
                                    Console.WriteLine("-----Operation completed successfully.-----");
                                }
                                else
                                {
                                    Console.WriteLine("-----Data not found.-----");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-----Invalid column name.-----");
                            }
                            break;
                        case "3":
                            Console.WriteLine("-----Delete operation-----");
                            Console.Write("Enter the name to delete ClassName/SujectName/TeacherName: ");
                            string deleteName = Console.ReadLine();

                            Console.Write("Enter the data for search: ");
                            string setValue = Console.ReadLine();

                            PropertyInfo deleteProperty = typeof(Classroom).GetProperty(deleteName);

                            if (deleteProperty != null)
                            {

                                var allClassrooms = dbContext.Classrooms.ToList();

                                // filter the Classroom records 
                                var classrooms = allClassrooms.FirstOrDefault(c => deleteProperty.GetValue(c).ToString() == setValue);

                                if (classrooms != null)
                                {

                                    //delete
                                    dbContext.Classrooms.Remove(classrooms);

                                    dbContext.SaveChanges();
                                    Console.WriteLine("-----Operation completed successfully.-----");
                                }
                                else
                                {
                                    Console.WriteLine("-----Data not found.-----");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-----Invalid column name.-----");
                            }

                            break;

                        case "4":

                            Console.WriteLine("-----View Operation-----");
                            List<Classroom> classroomList = dbContext.Classrooms.ToList();

                            Console.WriteLine("----All Teacher Name---");
                            foreach (Classroom cls in classroomList)
                            {
                                Console.WriteLine(cls.TeacherName);
                            }

                            Console.WriteLine("----All Subject Name---");
                            foreach (Classroom cls in classroomList)
                            {
                                Console.WriteLine(cls.SujectName);
                            }

                            Console.WriteLine("----All Class Name---");
                            foreach (Classroom cls in classroomList)
                            {
                                Console.WriteLine(cls.ClassName);
                            }

                            dbContext.SaveChanges();


                            break;
                        default:
                            Console.WriteLine("-----Invalid choice. Please try again.-----");
                            break;
                    }
                    
                }
            }
            else if (teacherLogin != null && userLogin == null)
            {
                Console.WriteLine("-----Teacher login successful-----");

                while (true)
                {

                    Console.WriteLine("1. Insert Students Information");
                    Console.WriteLine("2. View data");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            //insert
                            //Classroom classroom = new Classroom();
                            TeacherRoom teacherRoom = new TeacherRoom();
                            //Console.Write("Enter class name: ");
                            //teacherRoom.ClassName = Console.ReadLine();


                            
           
                            string propertyName = "ClassName";

                            Console.Write("Enter Class Name: ");
                            string targetValue = Console.ReadLine();

                            PropertyInfo property = typeof(Classroom).GetProperty(propertyName);

                            if (property != null)
                            {

                                var allClassrooms = dbContext.Classrooms.ToList();

                                // filter records dynamic property
                                var classrooms = allClassrooms.FirstOrDefault(c => property.GetValue(c).ToString() == targetValue);

                                if (classrooms != null)
                                {
                                    teacherRoom.ClassName = targetValue;
                                    Console.Write("Enter subject name: ");
                                    teacherRoom.SubjectName = Console.ReadLine();

                                    Console.Write("Enter student name: ");
                                    teacherRoom.StudentName = Console.ReadLine();

                                    Console.Write("Enter grade: ");
                                    teacherRoom.Grade = int.Parse(Console.ReadLine());

                                    dbContext.TeachersTeachers.Add(teacherRoom);
                                    dbContext.SaveChanges();
                                    Console.WriteLine("-----Operation completed successfully.-----");
                                }
                                else
                                {
                                    Console.WriteLine("-----You are not assign to this class.-----");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-----Invalid column name.-----");
                            }


                            break;
                        case "2":
                            //edit
                           
                            break;

                        default:
                            Console.WriteLine("-----Invalid choice. Please try again.-----");
                            break;
                    }

                }
            }
            else
            { Console.WriteLine("-----Provide correct information-----"); }

           

             


        }
    }
}
