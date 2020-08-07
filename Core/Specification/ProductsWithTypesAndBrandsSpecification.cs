using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
  /// <summary>
  /// Specification defined for returning the types and brands
  /// with the products returns
  /// </summary>
  public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
  {
    public ProductsWithTypesAndBrandsSpecification()
    {
      AddInclude(x => x.ProductType);
      AddInclude(X => X.ProductBrand);
    }

    public ProductsWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
    {
      AddInclude(x => x.ProductType);
      AddInclude(X => X.ProductBrand);
    }
  }
}