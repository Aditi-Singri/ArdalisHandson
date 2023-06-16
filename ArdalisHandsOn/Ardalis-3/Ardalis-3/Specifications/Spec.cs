using Ardalis.Specification;
using Ardalis_3.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Ardalis_3.Specifications
{
    public class Spec: Specification<OurEnvironment>
    {
        public Spec(string name)
        {
            Query.Where(h => h.Name == name);
        }
    }
}
