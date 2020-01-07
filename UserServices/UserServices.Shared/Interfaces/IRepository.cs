using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.Interface
{
    internal interface IRepository<Type, IdType>
    {
        bool Remove(Type entity);

        bool Remove(IdType id);

        IEnumerable<Type> GetAll();

        Type GetById(IdType id);

        Type Insert(Type entity);

        Type Update(Type entity);
    }
}