using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using School.Common.Auth;
using School.Service.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace School.Api.Filters
{
    public class AuthorizeAccessFilter : IAuthorizationFilter
    {
        private readonly string _actionName;
        private readonly HttpContextHelper _httpHelper;
        private readonly IUserService _userService;
      //  private readonly IJwtHandler _jwtHandler;

        public AuthorizeAccessFilter(HttpContextHelper httpHelper, IUserService userService,
            string actionName
                                     )
        {
            _actionName = actionName;
            _httpHelper = httpHelper;
            _userService = userService;
          //  _jwtHandler = jwtHandler;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Guid userId = _httpHelper.GetUserId();

            bool isAuthorized = _userService.DoesUseHaveAccessTo(userId, _actionName);

            if (!isAuthorized)
            {
                context.Result = new UnauthorizedResult();
            }
        }


    }
}
