using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace School.Infra.Repositories.Access_Control
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly AccessControlContext _context;

        public FeatureRepository(AccessControlContext context)
        {
            _context = context;
        }
        public IEnumerable<Feature> FindBy(Expression<Func<Feature, bool>> predicate)
        {
            IQueryable<Feature> results = _context.Features
                                            .Where(predicate);
            return results;
        }

        public Feature FindByKey(Guid id)
        {
            var feature = _context.Features.Find(id);
            if (feature == null)
                return null;

            return feature;
        }

        public IEnumerable<Feature> GetAll()
        {
            var features = _context.Features.ToList();
            return features;
        }

        public void Insert(Feature entity)
        {
            _context.Features.Add(entity);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
