using System;
using System.Collections.Generic;
using System.Text;

namespace Tec.CloudApp.Business
{
    using Tec.CloudApp.Commons.Contracts.Business;
    using Tec.CloudApp.Commons.Contracts.Persistence;
    using Tec.CloudApp.Commons.Model;

    public class UserBusiness : IUserBusiness
    {
        private readonly IUserPersistence persistence;

        public UserBusiness(IUserPersistence persistence)
        {
            this.persistence = persistence;
        }

        public List<UserDto> GetUsers()
        {
           return  this.persistence.GetUsers();
        }
    }
}
