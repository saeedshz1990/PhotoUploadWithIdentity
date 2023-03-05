using Microsoft.AspNetCore.Http;

namespace PhotoUploadWithIdentity.Infrastructure {
    public interface IFileUploader {
        string Upload(IFormFile file, string path);
    }
}
