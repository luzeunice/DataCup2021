

namespace Tec.CloudApp.Persistence
{
    
    using System.Collections.Generic;

    using Tec.CloudApp.Commons.Contracts.Persistence;
    using Tec.CloudApp.Commons.Model;

    public class UserPresistence : IUserPersistence
    {

        public List<UserDto> GetUsers()
        {
            return new List<UserDto>()
                       {
                           new UserDto {Id = 1 ,Age = 20, Campus = "Queretaro", LastName = "Sanchez", Name =  "Armando"},
                           new UserDto {Id = 2 ,Age = 23, Campus = "Cdmx", LastName = "Vargas", Name =  "Elizabeth"},
                           new UserDto {Id = 3 ,Age = 26, Campus = "Queretaro", LastName = "Ortiz", Name =  "Andres"},
                           new UserDto {Id = 4 ,Age = 22, Campus = "Puebla", LastName = "Jimenze", Name =  "Maria"},
                           new UserDto {Id = 5 ,Age = 21, Campus = "Queretaro", LastName = "Sanchez", Name =  "Armando"},
                           new UserDto {Id = 6 ,Age = 20, Campus = "Monterrey", LastName = "Hernandez", Name =  "Viridiana"},
                           new UserDto {Id = 7 ,Age = 19, Campus = "Cdmx", LastName = "Perez", Name =  "Carlos"},
                           new UserDto {Id = 1 ,Age = 20, Campus = "Queretaro", LastName = "Sanchez", Name =  "Armando"},
                           new UserDto {Id = 2 ,Age = 23, Campus = "Cdmx", LastName = "Vargas", Name =  "Elizabeth"},
                           new UserDto {Id = 3 ,Age = 26, Campus = "Queretaro", LastName = "Ortiz", Name =  "Andres"},
                           new UserDto {Id = 4 ,Age = 22, Campus = "Puebla", LastName = "Jimenze", Name =  "Maria"},
                           new UserDto {Id = 5 ,Age = 21, Campus = "Queretaro", LastName = "Sanchez", Name =  "Armando"},
                           new UserDto {Id = 6 ,Age = 20, Campus = "Monterrey", LastName = "Hernandez", Name =  "Viridiana"},
                           new UserDto {Id = 7 ,Age = 19, Campus = "Cdmx", LastName = "Perez", Name =  "Carlos"}
                       };

            // Fake  info for development 
            //return new List<UserDto>()
            //           {
            //               new UserDto {Id = 1 ,Age = 10, Campus = "Campus 1", LastName = "Last Name 1", Name =  "Name 1"},
            //               new UserDto {Id = 2 ,Age = 23, Campus = "Campus 2", LastName = "Last Name 6", Name =  "Name 2"},
            //               new UserDto {Id = 3 ,Age = 36, Campus = "Campus 1", LastName = "Last Name 5", Name =  "Name 3"},
            //               new UserDto {Id = 4 ,Age = 42, Campus = "Campus 3", LastName = "Last Name 3", Name =  "Name 4"},
            //               new UserDto {Id = 5 ,Age = 51, Campus = "Campus 2", LastName = "Last Name 2", Name =  "Name 5"},
            //           };
        }

    }
}
