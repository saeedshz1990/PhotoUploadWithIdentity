﻿namespace PhotoUploadWithIdentity.Infrastructure {
    public interface IAuthHelper {

        void SignOut();
        bool IsAuthenticated();
        void SignIn(AuthViewModel account);
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
        List<int> GetPermissions();
        long CurrentAccountId();
        string CurrentAccountMobile();
    }
}
