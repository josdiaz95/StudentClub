namespace StudentClub
{
    public class Student
    {
        private string _firstName;

        private string _lastName;
        
        private string _email;
   


        public Student(string firstName, string lastName, string email)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
        }

        public override string ToString()
        {

            return _firstName + " " + _lastName + "| " + _email;
        }
    }
}