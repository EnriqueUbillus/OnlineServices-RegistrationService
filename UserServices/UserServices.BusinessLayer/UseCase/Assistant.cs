using System;
using System.Collections.Generic;
using System.Text;
using UserServices.BusinessLayer.Extensions;
using UserServices.Shared.TransferObject;

namespace UserServices.BusinessLayer.UseCase
{
    public class Assistant
    {
        public bool AddUser(UserTO userTO)
        {
            if (userTO == null)
                throw new ArgumentNullException(nameof(userTO));

            if (userTO.ID != 0)
                throw new Exception("Existing user");

            try
            {
                //Hack: UserRepository IRepository - Silvain
                //iMSUnitOfWork.UserRepository.Add(userTO.ToDomain().ToTransferObject());

                return true;
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
