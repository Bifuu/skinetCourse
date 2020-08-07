using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
  /// <summary>
  /// Defines additional specifications to work with generic repos
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface ISpecification<T>
  {
    /// <summary>
    /// Additional Criteria that may be required for returning data
    /// </summary>
    /// <value></value>
    Expression<Func<T, bool>> Criteria { get; }
    /// <summary>
    /// List of additional includes for the specificiations
    /// </summary>
    /// <value></value>
    List<Expression<Func<T, object>>> Includes { get; }
  }
}