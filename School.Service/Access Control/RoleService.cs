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
        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

     
    }
}
