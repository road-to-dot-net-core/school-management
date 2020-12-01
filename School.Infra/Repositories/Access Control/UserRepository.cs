using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using School.Domain.Repositories.Access_Control;
using School.Contract.Response.Access_Control.Menu;

namespace School.Infra.Repositories.Access_Control
{
    public class UserRepository : IUserRepository
    {
        private readonly AccessControlContext _context;

        public UserRepository(AccessControlContext context)
        {
            _context = context;
        }
        public bool DoesUserHaveAccessTo(Guid userId, string actionName)
        {
            var data = from x in _context.Users
                       from y in _context.Roles
                       from yy in y.RolePermissions
                       from z in _context.Permissions
                       from zz in z.PermissionFeatures
                       from t in _context.Features

                       where x.Id == userId && t.Action == actionName && x.RoleId == y.Id

                       select new
                       {
                           x.Id
                       };


            return data.Count() > 0;
        }

        public IEnumerable<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            IQueryable<User> results = _context.Users
                                               .Where(predicate);
            return results;
        }

        public User FindByKey(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return null;
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public UserMenuResponse GetMenu(Guid userId)
        {
            var user = _context.Users.Find(userId);
            //var menuItems = (from x in _context.Users
            //                 from y in _context.Roles
            //                 from yy in y.RolePermissions
            //                 from z in _context.Permissions
            //                 from zz in z.PermissionFeatures
            //                 from t in _context.Features

            //                 where t.RoutingLink != null

            //                 select new
            //                 {
            //                     //Id=t.Id,
            //                     UserId = x.Id,
            //                     FirstName = x.FirstName,
            //                     LastName = x.LastName,
            //                     Email = x.Email,
            //                     Title = t.Label,
            //                     Icon = t.Logo,
            //                     RoutingLink = t.RoutingLink,
            //                     //ParentId=t.ParentId
            //                 }).ToList();
            var menuItems = (from t in _context.Features

                             where t.RoutingLink != null

                             select new
                             {
                                 //Id=t.Id,
                                 //UserId = x.Id,
                                 //FirstName = x.FirstName,
                                 //LastName = x.LastName,
                                 //Email = x.Email,
                                 Title = t.Label,
                                 Icon = t.Logo,
                                 RoutingLink = t.RoutingLink,
                                 //ParentId=t.ParentId
                             }).ToList();
            if (menuItems != null)
                return new UserMenuResponse
                {
                    //Id = menuItems.FirstOrDefault().UserId,
                    //FirstName = menuItems.FirstOrDefault().FirstName,
                    //LastName = menuItems.FirstOrDefault().LastName,
                    //Email = menuItems.FirstOrDefault().LastName,
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Items = menuItems.Select(a =>
                    new MenuResponseItem
                    {
                        Title = a.Title,
                        Icon = a.Icon,
                        RoutingLink = a.RoutingLink
                    }).ToList()

                };
            else
                return null;

        }

        public void Insert(User entity)
        {
            _context.Users.Add(entity);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
