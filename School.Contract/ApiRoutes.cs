using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract
{
    public static class ApiRoutes
    {
        public const string Root = "";


        public const string Base = Root ;

        public static class Users
        {
            public const string GetAll = Base + "/users";

            public const string Post = Base + "/users";

            public const string Get = Base + "/users/{id:Guid}";

            public const string Register = Base + "/users";


        }



        public static class Identity
        {
            public const string LogIn = Base + "/identity/login";

            public const string LogOut = Base + "/identity/logout";

            public const string Refresh = Base + "/identity/refresh";

            public const string ChangePassword = Base + "/identity/changePassword";

        }

        public static class Roles
        {
            public const string GetAll = Base + "/roles";

            public const string Get = Base + "/roles/{id:Guid}";


        }
    }
}
