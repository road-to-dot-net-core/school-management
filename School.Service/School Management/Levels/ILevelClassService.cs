
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service
{
    public interface ILevelClassService
    {
        bool InsertLevelClass(string name,int level);
     
    }
}
