using AutoMapper;
using School.Contract.Commands.AccessControl.Permissions;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Access_Control.Permissions;
using School.Contract.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Automapper
{
    public class CreateProfile:Profile
    {
        public CreateProfile()
        {
            CreateMap<RegisterUserRequest, RegisterUserCommand>();

            CreateMap<InsertPermissionRequest, InsertPermissionCommand>();
            CreateMap<UpdatePermissionRequest, UpdatePermissionCommand>();
            CreateMap<DeletePermissionRequest, DeletePermissionCommand>();

        }

    }
}
