using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace School.Domain.Repositories.Access_Control
{
    public interface IFeatureRepository
    {
        Feature FindByKey(Guid id);
        IEnumerable<Feature> GetAll();
        void Insert(Feature entity);
        IEnumerable<Feature> FindBy(Expression<Func<Feature, bool>> predicate);

        bool Save();
    }
}
