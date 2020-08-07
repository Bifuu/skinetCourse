using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
  public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
  {
    public System.Threading.Tasks.Task<T> GetByIdAsync(int id)
    {
      throw new System.NotImplementedException();
    }

    public System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<T>> ListAllAsync()
    {
      throw new System.NotImplementedException();
    }
  }
}