using PhotoUploadWithIdentity.Entities.Accounts;
using System.Security;

namespace PhotoUploadWithIdentity.Entities.Roles {
    public class Role {
        public Role()
        {
            Accounts = new List<Account>();
            Permissions = new List<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Account> Accounts { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
