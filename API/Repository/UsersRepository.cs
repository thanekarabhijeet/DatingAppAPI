using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DatingAppContext _context;

        public UsersRepository(DatingAppContext context)
        {
            _context = context;
        }

        public async Task<Users> GetUserById(int userid)
        {
            var user = await _context.Users.FindAsync(userid);
            return user;
        }

        public async Task<List<Users>> GetUsersList()
        {
            //
            var user = await _context.Users.ToListAsync();
            return user;
        }
    }

}
