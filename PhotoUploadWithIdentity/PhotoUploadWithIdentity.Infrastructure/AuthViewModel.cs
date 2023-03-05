namespace PhotoUploadWithIdentity.Infrastructure {
    public class AuthViewModel {

        public AuthViewModel() {
            Permissions = new List<int>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public List<int> Permissions { get; set; }
    }
}
