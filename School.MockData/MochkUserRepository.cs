using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace School.MockData
{
    public class MochkUserRepository : IUserRepository
    {
        List<User> _users;
        List<Permission> _permissions;
        List<Role> _roles;
        List<Feature> _features;

        public MochkUserRepository()
        {
            string _pass = "P@ssw0rd";
            Password password = Password.Create(_pass).Value;

            //features 
            _features = new List<Feature>();
            Feature feature_1 = new Feature("Get All users", "GetAllUsers", "Users", "Get", "");
            Feature feature_2 = new Feature("Edit user", "EditUser", "Users", "Post", "");
            Feature feature_3 = new Feature("Register a user", "RegisterUser", "Users", "Post", "");

            _features.Add(feature_1);
            _features.Add(feature_2);
            _features.Add(feature_3);
            //permissions
            List<Guid> _readFeatures = new List<Guid>();
            _readFeatures.Add(feature_1.Id);


            List<Guid> _whriteFeatures = new List<Guid>();
            _whriteFeatures.Add(feature_2.Id);
            _whriteFeatures.Add(feature_3.Id);

            _permissions = new List<Permission>();

            Permission permission_1 = new Permission("Users read only", "Users read only", _readFeatures);
            Permission permission_2 = new Permission("Users whrite only", "Users whrite only", _whriteFeatures);



            //roles
            _roles = new List<Role>();

            List<Guid> _adminPermissions = new List<Guid>();
            _adminPermissions.Add(permission_1.Id);
            _adminPermissions.Add(permission_2.Id);


            List<Guid> _endUserPermissions = new List<Guid>();
            _endUserPermissions.Add(permission_2.Id);

            Role role_1 = new Role("Admin It", "Admin It", _adminPermissions);
            Role role_2 = new Role("End User", "End User", _endUserPermissions);


            _users = new List<User>();

            User user_1 = new User("firstName_1", "lastName_1", password, "firstName_1.lastName_1@gmail.com", role_1.Id, Guid.Empty);
            User user_2 = new User("firstName_2", "lastName_2", password, "firstName_2.lastName_2@gmail.com", role_1.Id, user_1.Id);
            User user_3 = new User("firstName_3", "lastName_3", password, "firstName_3.lastName_3@gmail.com", role_2.Id, user_1.Id);
            User user_4 = new User("firstName_4", "lastName_4", password, "firstName_4.lastName_4@gmail.com", role_2.Id, user_1.Id);
            User user_5 = new User("firstName_5", "lastName_5", password, "firstName_5.lastName_5@gmail.com", role_2.Id, user_1.Id);
            User user_6 = new User("firstName_6", "lastName_6", password, "firstName_6.lastName_6@gmail.com", role_2.Id, user_1.Id);
            User user_7 = new User("firstName_7", "lastName_7", password, "firstName_7.lastName_7@gmail.com", role_2.Id, user_1.Id);
            User user_8 = new User("firstName_8", "lastName_8", password, "firstName_8.lastName_8@gmail.com", role_2.Id, user_1.Id);
            User user_9 = new User("firstName_9", "lastName_9", password, "firstName_9.lastName_9@gmail.com", role_2.Id, user_1.Id);
            User user_10 = new User("firstName_10", "lastName_10", password, "firstName_10.lastName_10@gmail.com", role_2.Id, user_1.Id);

            _users.Add(user_1);
            _users.Add(user_2);
            _users.Add(user_3);
            _users.Add(user_4);
            _users.Add(user_5);
            _users.Add(user_6);
            _users.Add(user_7);
            _users.Add(user_8);
            _users.Add(user_9);
            _users.Add(user_10);

        }

        public bool DoesUserHaveAccessTo(Guid userId, string actionName)
        {
            var data = from x in _users
                       from y in _roles
                       from yy in y.RolePermissions
                       from z in _permissions
                       from zz in z.PermissionFeatures
                       from t in _features

                       where x.Id == userId && t.Action == actionName && x.RoleId == y.Id

                       select new
                       {
                           x.Id
                       };


            return data.Count() > 0;
        }

        public IEnumerable<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public User FindByKey(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            List<User> _users = new List<User>();
            _users.Add(new User("user name_1", "user_name 2", Password.Create("test").Value, "user@gmail.com", Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F"),
                Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F")));
            _users.Add(new User("user name_1", "user_name 2", Password.Create("test").Value, "user@gmail.com", Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F"),
            Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F")));
            _users.Add(new User("user name_1", "user_name 2", Password.Create("test").Value, "user@gmail.com", Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F"),
            Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F")));
            _users.Add(new User("user name_1", "user_name 2", Password.Create("test").Value, "user@gmail.com", Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F"),
            Guid.Parse("D624FB96-8B2C-412D-9E79-521E87B21C4F")));
            return _users;
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
