using Schools.Domain.Models.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Infra.Repositories.Access_Control
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly AccessControlContext _context;

        public RefreshTokenRepository(AccessControlContext context)
        {
            _context = context;
        }
        public bool Add(RefreshToken refresh_token)
        {
            _context.RefreshTokens.Add(refresh_token);
            return _context.SaveChanges() > 0;
        }

        public RefreshToken Get(string refresh_token) => _context.RefreshTokens.Where(a => a.Refresh_Token == refresh_token).FirstOrDefault();


        public bool Refresh(RefreshToken refresh_token)
        {
            return _context.SaveChanges() > 0;
        }

     

    }
}
