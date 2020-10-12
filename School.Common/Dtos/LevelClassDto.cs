using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Dtos
{
    public sealed class LevelClassDto
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public LevelClassDto()
        {

        }

        public LevelClassDto(string name,int level)
        {
            Name = name;
            Level = level;
        }

    }
}
