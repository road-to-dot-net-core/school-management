using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Repositories
{
    public interface ILevelClassRepository
    {
        bool InsertLevelRepository(LevelClass levelClass);
       // IEnumerable<LevelClassDto> GetAll();
    }
}
