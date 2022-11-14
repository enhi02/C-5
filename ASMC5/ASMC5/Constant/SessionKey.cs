using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonAn.Constant
{
    public static class SessionKey
    {
        public static class User
        {
            public const string UserName = "UserName";
            public const string FullName = "FullName";
            public const string Valid = "Valid";
            public const string UserContext = "UserContext";
        }

        public static class KhachHang
        {
            public const string KH_Email = "KH_Email";
            public const string KH_FullName = "KH_FullName";
        }
    }
}
