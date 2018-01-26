using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee.Model
{
    public class Category : BaseCategory
    {
        public UserAccount Creator { get; set; }
        public ContentStatus ContentStatus { get; set; }


        public List<Category> Categories { get; set; }
        public List<Groups> Groups { get; set; }
    }
}