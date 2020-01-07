using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;

namespace UserServices.Shared.Interface
{
    interface IAssistantRepository : IRepository<UserTO, int>
    {
        bool CreateUser();

    }
}
