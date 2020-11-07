using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Repositories.Access_Control
{
    public interface IRefreshTokenRepository
    {
        RefreshToken Get(string refresh_token);

        bool Refresh(RefreshToken refresh_token);

        bool Add(RefreshToken refresh_token);
    }
}
