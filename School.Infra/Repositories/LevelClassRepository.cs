using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Repositories;
using System.Linq;
using School.Common.Dtos;
using System.Security.Cryptography;

namespace School.Infra.Repositories
{
    public class LevelClassRepository : ILevelClassRepository
    {
        private readonly SchoolContext _schoolContext;

        public LevelClassRepository(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public IEnumerable<LevelClassDto> GetAll()
        {
            IEnumerable<LevelClassDto> levelClasses;
            levelClasses = (from x in _schoolContext.LevelClasses
                            select new LevelClassDto
                            {
                                Name = x.ClassName,
                                Level = x.Level
                            });

            return levelClasses;
        }

        public bool InsertLevelRepository(LevelClass levelClass)
        {
            _schoolContext.LevelClasses.Add(levelClass);
            return _schoolContext.SaveChanges() > 0;
        }
    }
}
