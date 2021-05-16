using System;
using System.Collections.Generic;
using System.Text;

namespace Tec.CloudApp.Commons.Contracts.Business
{
    using Tec.CloudApp.Commons.Model;

    public interface IUserBusiness
    {
        List<UserDto> GetUsers();
    }
}
