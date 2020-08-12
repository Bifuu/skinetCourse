using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy => throw new NotImplementedException();

        public Expression<Func<T, object>> OrderByDescending => throw new NotImplementedException();

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}