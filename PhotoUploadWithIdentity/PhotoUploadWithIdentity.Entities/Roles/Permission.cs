namespace PhotoUploadWithIdentity.Entities.Roles {
    public class Permission {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; } = string.Empty;
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
