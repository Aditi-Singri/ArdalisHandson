using Ardalis.Specification;
using Ardalis_1.Models;

namespace Ardalis_1.Repositories.Specifications
{
    public class HeroByIsAliveAndIsAvengerSpec : Specification<Hero>
    {
        public HeroByIsAliveAndIsAvengerSpec(bool isAlive, bool isAvenger)
        {
            Query.Where(h => h.IsAlive == isAlive || h.IsAvenger == isAvenger);
            Query.OrderByDescending(x => x.Id)
     .ThenByDescending(x => x.Name);
        }
    }


}
