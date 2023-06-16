using Ardalis.Specification;
using Ardalis_1.Models;

namespace Ardalis_1.Repositories.Interfaces
{
    public interface IHeroRepository
    {
        List<Hero> GetAllHeroes(Specification<Hero> specification);

    }
}
