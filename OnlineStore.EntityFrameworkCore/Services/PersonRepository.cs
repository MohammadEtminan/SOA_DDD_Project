using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.EntityFrameworkCore.Services
{
    public class PersonRepository :
         Frameworks.Base.BaseRepository<OnlineStoreDbContext, Person, Guid>,
         Domain.Repositories.IPersonRepository
    {
        #region [- ctor -]
        public PersonRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {

        }
        #endregion

        #region [- FindByNameAsync(string name) -]
        public async Task<Person> FindByNameAsync(string name)
        {
            return await DbSet.FirstOrDefaultAsync(p => p.FirstName == name);
        }
        #endregion
    }
}
