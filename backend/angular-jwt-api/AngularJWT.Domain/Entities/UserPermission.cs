using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJWT.Domain.Entities
{
    public class UserPermission
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string UserId { get; set; } // Kullanıcı kimliği
        public string Permission { get; set; } // İzin adı
    }
}
