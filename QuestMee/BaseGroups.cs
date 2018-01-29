using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseGroup : BaseEntity
    {
        public int CategoryId { get; set; }
        public int UserGroupsId { get; set; }



        public string Name { get; set; }
    }
}