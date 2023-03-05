using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoUploadWithIdentity.Infrastructure {
    public interface IPermissionExposer {
        Dictionary<string, List<PermissionDto>> Expose();

    }
}
