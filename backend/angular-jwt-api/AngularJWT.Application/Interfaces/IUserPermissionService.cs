using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJWT.Application.Interfaces
{
    public interface IUserPermissionService
    {
        Task<IEnumerable<string>> GetUserPermissionsAsync(string userId);
    }
}
