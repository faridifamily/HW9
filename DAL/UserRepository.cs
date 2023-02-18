using HW9.Models;

namespace HW9.DAL
{
    public class UserRepository
    {
        public static List<User> users = new List<User>
        {
            new User{Id = 1, Name = "amir", Family = "faridi", Email = "amirfaridi976@gmail.com", Password = "1234" },
            new User{Id = 2, Name = "mehrdad", Family = "faridi", Email = "mehrdadfaridi91@gmail.com", Password = "4321" }
        };
        public static List<User> Users()
        {
            return users;
        }
        public static int Count() { return users.Count; }
    }
}
