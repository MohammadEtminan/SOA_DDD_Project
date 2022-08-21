using System;
using System.Threading.Tasks;
using OnlineStore.Domain.Aggregates;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace OnlineStore.Domain.Repositories
{
    [ScopedService]
    public interface IPersonRepository : Contract.Abstracts.IRepository<Person, Guid>
    {
        Task<Person> FindByNameAsync(string name);

    }
}
