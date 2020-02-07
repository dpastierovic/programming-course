using System.Collections.Generic;

namespace WindowsFormApp.DataModel
{
    public interface IUserRepository
    {
        void Create(User user);
        User Read(string name, string surname);
        void Delete(User user);
        void Delete(string name, string surname);
        IEnumerable<User> ReadAllUsers();
    }
}
