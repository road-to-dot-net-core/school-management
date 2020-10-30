using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class Level:BaseEntity
    {
        public string Name { get; private set; }
        public virtual ICollection<LevelClass> LevelClasses { get; set; }

        public Level()
        {

        }
        public Level(string name)
        {
            Name = name;
        }
    }
}
