using System;
using System.Collections.Generic;
using System.Text;

namespace Tec.CloudApp.Commons.Contracts.Persistence
{
    using Tec.CloudApp.Commons.Model;

    public interface IUserPersistence
    {
        List<UserDto> GetUsers();
    }
}
