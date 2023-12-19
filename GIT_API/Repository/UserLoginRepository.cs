using GIT_API.Data;
using GIT_API.Models;
using GIT_API.Repository.IRepository;

namespace GIT_API.Repository
{
    public class UserLoginRepository:Repository<UserLogin>,IUserLoginRepository
    {
        private readonly ApplicationDbContext _context;

        public UserLoginRepository(ApplicationDbContext context):base(context) 
        {
          _context= context;
        }
    }
}
