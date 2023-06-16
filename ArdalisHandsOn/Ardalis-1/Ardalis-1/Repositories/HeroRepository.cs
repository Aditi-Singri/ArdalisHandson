using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Ardalis_1.Data;
using Ardalis_1.Models;
using Ardalis_1.Repositories.Interfaces;

namespace Ardalis_1.Repositories
{
   
        public class HeroRepository : IHeroRepository
        {
            private readonly DataContext _dbContext;

            public HeroRepository(DataContext dbContext)
            {
                _dbContext = dbContext;
            }

            public List<Hero> GetAllHeroes(Specification<Hero> specification)
            {
                var queryResult = SpecificationEvaluator.Default.GetQuery(
                    query: _dbContext.Heroes.AsQueryable(),
                    specification: specification);

                return queryResult.ToList();
            }

        public List<Hero> GetAllHeroes(ISpecification<Hero> specification)
        {
            throw new NotImplementedException();
        }
    }
    }

