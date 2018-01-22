using System.Collections;
using System.Collections.Generic;
using Example.Data.Entity;

namespace Example.Data.Repository
{
    public interface IDataRepository
    {
        IList<User> GetUserList();
    }
}