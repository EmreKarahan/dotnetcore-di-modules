using System.Collections.Generic;
using Example.Data.Entity;

namespace Example.Data.Repository.Impl
{
    public class DataRepository : IDataRepository
    {
        public IList<User> GetUserList()
        {
          return new List<User>
          {
              new User
              {
                  Firstname = "Alexandra",
                  Lastname = "Reid",
                  Email = "lexandra.reid@example.com",
                  Id = 1
              },
              new User()
              {
                  Email = "stoffel.dielen@example.com",
                  Firstname = "Stoffel",
                  Lastname = "Dielen",
                  Id = 2
              },
              new User
              {
                  Email = "Megan.holt@example.com",
                  Firstname = "Megan",
                  Lastname = "Holt"
                  Id = 3
              }
          };
        }
    }
}