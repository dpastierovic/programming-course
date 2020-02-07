using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp.DataModel
{
    public class UserRepository : IUserRepository
    {
        readonly List<User> _users = new List<User>();

        public void Create(User user)
        {
            _users.Add(user);
        }

        public void Delete(User user)
        {
            _users.Remove(user);
        }

        public void Delete(string name, string surname)
        {
            _users.Remove(_users.First(user => user.Name == name && user.Surname == surname));
        }

        public User Read(string name, string surname)
        {
            return _users.First(user => user.Name == name && user.Surname == surname);
        }

        public IEnumerable<User> ReadAllUsers()
        {
            return _users;
        }
    }
}
