using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Application.Common.Interfaces
{
    public  interface ICurrentUserService
    {
        string UserId { get; }
    }
}
