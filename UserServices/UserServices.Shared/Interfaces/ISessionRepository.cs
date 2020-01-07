using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;
using OnlineServices.Shared.DataAccessHelpers;

namespace UserServices.Shared.Interface
{
    internal interface ISessionRepository : IRepositoryTemp<SessionTO, int>
    {
        List<UserTO> GetStudents(SessionTO session);
    }
}