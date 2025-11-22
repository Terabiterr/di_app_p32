using di_app.Models;

namespace di_app.Services
{
    public interface IServiceUser
    {
        IEnumerable<User> GetUsers();
        public User GetUserById(int id);
        public User UpdateUserById(int id, User user);
        public User DeleteUserById(int id);
    }
    public class ServiceUser : IServiceUser
    {
        List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "Ігор", Email = "igor@example.com" },
            new User { Id = 2, Name = "Олена", Email = "olena@example.com" },
            new User { Id = 3, Name = "Максим", Email = "max@example.com" },
            new User { Id = 4, Name = "Анна", Email = "anna@example.com" },
            new User { Id = 5, Name = "Дмитро", Email = "dmytro@example.com" }
        };

        public User DeleteUserById(int id)
        {
            var user = Users.Find
                (u => u.Id == id);
            if(user == null)
            {
                return null;
            }
            Users.Remove(user);
            return user;
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User UpdateUserById(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
