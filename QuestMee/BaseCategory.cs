using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseCategory : BaseEntity
    {
        public int UserAccountId { get; set; }
        public int ContentStatusId { get; set; }
        public int CategoryId { get; set; }



        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedTime { get; set; }
    }
}