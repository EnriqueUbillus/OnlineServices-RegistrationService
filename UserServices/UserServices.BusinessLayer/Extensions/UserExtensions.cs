using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;

namespace UserServices.BusinessLayer.Extensions
{
    public static class UserExtensions
    {
        public static User ToDomain(this UserTO userTo)
        {
            return new User
            {
                ID = userTo.ID,
                Name = userTo.Name,
                Email = userTo.Email,
                Company = userTo.Company,
                IsActivated = userTo.IsActivated, 
                Role = userTo.Role,
                Session = userTo.Session.ToDomain(),
            };
        }

        public static UserTO ToTransferObject(this User user)
        {
            return new UserTO 
            {
                ID = user.ID,
                Name = user.Name,
                Email = user.Email, 
                Company = user.Company, 
                IsActivated = user.IsActivated,
                Session = user.Session.ToTransferObject(),
                Role = user.Role,
            };
        }
    }
}
