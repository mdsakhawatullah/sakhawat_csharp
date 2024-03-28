using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AuthCheck
    {
        private readonly TrainingDbContext _context;

        public AuthCheck(TrainingDbContext context)
        {
            _context = context;
        }

        public UserRole Authenticate(string username, string password)
        {
           

            var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

                   return user?.Role ?? UserRole.Admin;
        }
    }
}
