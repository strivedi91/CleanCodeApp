using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Domain.Common
{
    public class AuditEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
