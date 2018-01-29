using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseUserGroup : BaseEntity
    {
        public int UserId { get; set; }
        public int GroupsId { get; set; }
    }
}