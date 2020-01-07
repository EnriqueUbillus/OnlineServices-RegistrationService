using UserServices.Shared.TransferObject;

namespace UserServices.Shared.Interface
{
    interface IUserRepository : IRepository<UserTO, int>
    {
        bool login();
        void logout();

    }
}
