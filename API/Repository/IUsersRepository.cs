using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository
{
    public interface IUsersRepository
    {
        //GetAllUsers
        Task<List<Users>> GetUsersList();

        Task<Users> GetUserById(int userid);
    }
}
