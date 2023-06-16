using Ardalis.Specification;
using Ardalis_2.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Ardalis_2.specification
{
    
        public class FetchById : Specification<Customers>, ISingleResultSpecification
        {
            public FetchById(int Id)
            {
                Query.Where(x => x.Id == Id);
            }
        }
    
}
