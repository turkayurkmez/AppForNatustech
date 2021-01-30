using Natustech.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Services
{
    public class FakeUserService
    {
        private List<User> users = new List<User>
        {
             new User{ Id=1, UserName="turkayurkmez", Password="123456", Name="Türkay", Role="Admin"},
             new User{ Id=2, UserName="emreunal", Password="123", Name="Emre",Role="Editor"},
             new User{ Id=2, UserName="alikisa", Password="654", Name="Ali", Role="User"}


        };

        public User UserIsValid(string userName, string password)
        {
            return users.FirstOrDefault(x => x.UserName == userName && x.Password == password);

        }
    }
}
