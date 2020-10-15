using School.Common.Dtos;
using School.Domain.Repositories;
using Schools.Domain;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace School.Service
{
    public class LevelClassService : ILevelClassService
    {
        private readonly ILevelClassRepository _levelClassRepository;

        public LevelClassService(ILevelClassRepository levelClassRepository)
        {
            _levelClassRepository = levelClassRepository;
        }

        public IEnumerable<LevelClassDto> GetAll()
        {
            return _levelClassRepository.GetAll();
        }

        public bool InsertLevelClass(string name,int level)
        {
            //var _levelClass = new LevelClass(level,name);//business layer

            // return _levelClassRepository.InsertLevelRepository(_levelClass);//data layer
            return true;

        }
    }
}
