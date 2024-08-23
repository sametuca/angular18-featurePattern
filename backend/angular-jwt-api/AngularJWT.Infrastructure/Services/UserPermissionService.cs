using AngularJWT.Application.Interfaces;
using AngularJWT.Infrastructure.Data;

namespace AngularJWT.Infrastructure.Services
{
    public class UserPermissionService : IUserPermissionService
    {
        private readonly ApplicationDbContext _context;

        public UserPermissionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetUserPermissionsAsync(string userId)
        {
            return await _context.UserPermissions
                                 .Where(up => up.UserId == userId)
                                 .Select(up => up.Permission)
                                 .ToListAsync();
        }
    }
}
