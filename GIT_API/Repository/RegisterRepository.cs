using GIT_API.Data;
using GIT_API.Models;
using GIT_API.Repository.IRepository;

namespace GIT_API.Repository
{
    public class RegisterRepository : Repository<UserDetail>,IRegisterRepository
    {
        private readonly ApplicationDbContext _context;
        public RegisterRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
