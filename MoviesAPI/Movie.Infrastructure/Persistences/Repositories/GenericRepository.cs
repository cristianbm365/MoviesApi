using Movie.Infrastructure.Commons.Bases;
using Movie.Infrastructure.Helpers;
using Movie.Infrastructure.Persistences.Interfaces;
using System.Linq.Dynamic.Core;

namespace Movie.Infrastructure.Persistences.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected IQueryable<TDTO> Ordering<TDTO>(BasePaginationRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = request.Order == "desc" ? request.OrderBy($"{request.Sort} descending") : queryable.OrderBy($"{request.Sort} ascending");
            
            if (request) queryDto = queryDto.Paginate(request);

            return queryDto;
        }
    }
}
