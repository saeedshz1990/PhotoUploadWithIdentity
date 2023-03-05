using PhotoUploadWithIdentity.Entities.Roles;

namespace PhotoUploadWithIdentity.Entities.Accounts {
    public class Account {
        public int Id { get; set; }
        public string Fullname { get; set; }=string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
