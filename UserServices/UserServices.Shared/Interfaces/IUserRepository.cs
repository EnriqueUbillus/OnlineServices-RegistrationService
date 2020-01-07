using OnlineServices.Shared.DataAccessHelpers;
using System.Collections.Generic;
using UserServices.Shared.TransferObject;

namespace UserServices.Shared.Interface
{
    internal interface IUserRepository : IRepositoryTemp<UserTO, int>
    {
        List<SessionTO> GetSessions(UserTO user);

        bool IsInSession(UserTO user, SessionTO session);
    }
}