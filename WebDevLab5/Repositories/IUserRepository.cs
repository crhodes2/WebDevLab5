using System.Collections.Generic;
using WebDevLab5.Data.Entities;

namespace WebDevLab5.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}
