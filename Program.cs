namespace StudentClub
{
    internal class Program
    {
        public static List<Student> studentList = new List<Student>();
        static void Main(string[] args)
        {
            int menuChoice;

            do
            { 

                Console.WriteLine("Student Club Management Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. List Students");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Which option would you like to select?");
                menuChoice = Convert.ToInt16(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DeleteStudent();
                        break;
                    case 3:
                        EditStudent();
                        break;
                    case 4:
                        ListStudent();
                        break;
                    case 5:
                        Console.WriteLine("**List of students in Club**");
                        foreach (var list in studentList)
                        {
                            Console.WriteLine(list);
                        }
                        Console.WriteLine("Thank you for using Student Club Management!");
                        break;
                }

            } while (menuChoice != 5);

        }


        static void AddStudent()
        {
            Console.WriteLine("What is the student's first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is the student's last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is the student's email address?");
            string email = Console.ReadLine();
            Student newStudent = new Student(firstName, lastName, email);
            studentList.Add(newStudent);
            Console.WriteLine("Student successfully added.");
        }

        static void ListStudent()
        { 
      
            foreach (var stduent in studentList)
            {
                Console.WriteLine(stduent);
            }

            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club.");
            }
        }


        static void DeleteStudent()
        {

            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club");
            }
            else
            {
                ListStudent();
                Console.WriteLine("Which student would you like to delete?");
                int delete = Convert.ToInt32(Console.ReadLine());
                studentList.RemoveAt(delete - 1);
                Console.WriteLine("Student successfully deleted.");
            }
        }

        static void EditStudent()
        {
            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club");
            }
            else
            {
                ListStudent();
                Console.WriteLine("Which student would you like to edit?");
                int edit = Convert.ToInt32(Console.ReadLine());
                studentList.RemoveAt(edit - 1);
                Console.WriteLine("Please enter the new first name:");
                string first = Console.ReadLine();
                Console.WriteLine("Please enter the new last name:");
                string last = Console.ReadLine();
                Console.WriteLine("Please enter the new email:");
                string newEmail = Console.ReadLine();
                Student update = new Student(first, last, newEmail);
                studentList.InsertRange(edit - 1, new[] { update });
                Console.WriteLine("Student information successfully updated!");

            }
        }

    }
}