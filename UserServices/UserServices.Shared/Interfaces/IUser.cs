using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.Interface
{
    internal interface IUser
    {
        bool Login();

        bool Logout();
    }
}