using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestMee.Model.Data.Repository
{
    public interface IRepository<TEntity, TentityId>
        where TEntity : BaseEntity<TentityId>
        where TentityId : struct
    {
        
    }
}
