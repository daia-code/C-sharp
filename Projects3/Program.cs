using System;


namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int option, nr = 0;
            Student[] students = new Student[100];
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add a new student");
                Console.WriteLine("2.Delete a student");
                Console.WriteLine("3.Change data about studing");
                Console.WriteLine("4.View students");
                Console.Write("Enter your option:");
                option = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                if (option == 1)
                {
                    Console.WriteLine("Enter name of student:");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter the address:");
                    String address = Console.ReadLine();
                    Console.WriteLine("Enter the faculty:");
                    String faculty = Console.ReadLine();
                    Console.WriteLine("Enter the degree subject:");
                    String degree = Console.ReadLine();
                    Console.WriteLine("Enter the year of study:");
                    int year = Int16.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    DataStudy dataStudy = new DataStudy(faculty, degree, year);
                    students[nr] = new Student(name, address, dataStudy);
                    nr++;
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter name of student:");
                        String name = Console.ReadLine();
                        for (int j = 0; j < students.Length; j++)
                        {
                            if (students[j]==null)
                            {
                                continue;
                            }
                            String studName = students[j].Name;
                            if (String.Equals(name,studName))
                            {
                                students[j] = null;
                                break;


                            }
                           
                            
                        }
                        break;

                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter name of student:");
                    String name = Console.ReadLine();
                    for (int j = 0; j < students.Length; j++)
                    {
                        String studName = students[j].Name;
                        if (String.Equals(name,studName )){
                            students[j].DataStudy = students[j].NewDataStudy();
                            break;

                        }
                    }
                    break;
                    
                }else if (option == 4)
                {
                    foreach (Student student in students)
                    {
                        if (student==null)
                        {
                            continue;
                        }
                        student.Describe();
                        
                    }

                }
                Console.WriteLine();
            } while (option != 0);
        }
    }
}
