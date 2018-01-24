using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseEntity<TEntityId>
    {
        public TEntityId Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}