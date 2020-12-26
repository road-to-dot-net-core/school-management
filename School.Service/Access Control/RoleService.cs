using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Roles;
using School.Contract.Response.Roles;
using Schools.Domain.Models.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public PagedList<RoleResponse> GetAll(QueryParameters queryParameters)
        {
            return _roleRepository.GetAll(queryParameters);
        }

        public RegisterRoleResponse Register(Role role)
        {
             _roleRepository.Insert(role);
            _roleRepository.Save();
            return new RegisterRoleResponse() { RoleId = role.Id };
        }
    }
}
