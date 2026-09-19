namespace Account_Registration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    public class StudentInfoClass
    {
        public static string FirstName = string.Empty;
        public static string LastName = string.Empty;
        public static string MiddleName = string.Empty;
        public static string Address = string.Empty;
        public static string Program = string.Empty;

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string txt)
        {
            return FirstName;
        }

        public static string GetLastName(string txt)
        {
            return LastName;
        }

        public static string GetMiddleName(string txt)
        {
            return MiddleName;
        }

        public static string GetAddress(string txt)
        {
            return Address;
        }

        public static string GetProgram(string txt)
        {
            return Program;
        }

        public static long GetAge(long number)
        {
            return Age;
        }

        public static long GetContactNo(long number)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long number)
        {
            return StudentNo;
        }
    }
}