using School.Contract.Response.Access_Control.Menu;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace School.Domain.Repositories.Access_Control
{
    public interface IUserRepository
    {
        User FindByKey(Guid id);
        IEnumerable<User> GetAll();
        void Insert(User entity);
        IEnumerable<User> FindBy(Expression<Func<User, bool>> predicate);

        bool Save();
        bool DoesUserHaveAccessTo(Guid userId, string actionName);

        IEnumerable<MenuResponse> GetMenu(Guid userId);
    }
}
