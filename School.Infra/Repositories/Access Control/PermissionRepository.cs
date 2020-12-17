using Microsoft.EntityFrameworkCore;
using School.Contract.Response.Access_Control;
using School.Contract.Response.Access_Control.Permissions;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Infra.Repositories.Access_Control
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly AccessControlContext _context;

        public PermissionRepository(AccessControlContext context)
        {
            _context = context;
        }

        public PermissionResponse FindByKey(Guid id)
        {
            var data = _context.Permissions
                .Include(a => a.PermissionFeatures)
                .ThenInclude(b => b.Feature)
                .Where(c => c.Id == id)
                .ToList()
                .Select(result => new PermissionResponse
                {
                    Id = result.Id,
                    Label = result.Label,
                    Description = result.Description,
                    CreatedOn=result.CreatedOn,
                    Features = result.PermissionFeatures.
                                    Select(d => new FeatureResponse
                                    {
                                        Id = d.FeatureId,
                                        Action = d.Feature.Action,
                                        Controller = d.Feature.Controller,
                                        Description = d.Feature.Description,
                                        Label = d.Feature.Label
                                    }).ToList()
                }).FirstOrDefault();

            return data;
        }

        public IEnumerable<PermissionResponse> GetAll()
        {
            var data = _context.Permissions
              .Include(a => a.PermissionFeatures)
              .ThenInclude(b => b.Feature)
              .ToList()
              .Select(result => new PermissionResponse
              {
                  Id = result.Id,
                  Label = result.Label,
                  Description = result.Description,
                  Features = result.PermissionFeatures.
                                  Select(d => new FeatureResponse
                                  {
                                      Id = d.FeatureId,
                                      Action = d.Feature.Action,
                                      Controller = d.Feature.Controller,
                                      Description = d.Feature.Description,
                                      Label = d.Feature.Label
                                  }).ToList()
              }).ToList();

            return data;
        }

        public void Insert(Permission entity)
        {
            _context.Permissions.Add(entity);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
