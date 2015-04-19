using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var marta = new User("martinkinkness2005", "Martha", "Stuard", 45);

            var george = new User("stark_killer2001", "George", "Martin", 65);

            Console.WriteLine("First User: {0} , Age : {1}, Date Signed : {2}", marta.Name, marta.Age, marta.SignedDate);
            Console.WriteLine("Second User: {0} , Age : {1}, Date Signed : {2}", george.Name, george.Age, george.SignedDate);

            Console.ReadLine();
        }
    }

    class User
    {
        public User(string login, string name, string secondName, int age)
        {
            Login = login;
            Name = name;
            SecondName = secondName;
            Age = age;
            SignedDate = DateTime.Now;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public DateTime SignedDate { get; private set; }
    }
}
