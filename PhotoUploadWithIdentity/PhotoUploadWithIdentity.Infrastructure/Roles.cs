namespace PhotoUploadWithIdentity.Infrastructure {
    public static class Roles {

        public const string Administrator = "1";
        public const string SystemUser = "2";
        public const string Photographer = "3";

        public static string GetRoleBy(int id) {
            switch (id) {
                case 1:
                    return "مدیرسیستم";
                    case 2:
                    return "کاربر سیستمی";
                case 3:
                    return "عکاس";
                default:
                    return "";
            }
        }
    }
}
