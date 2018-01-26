using System.Collections.Generic;

namespace QuestMee.Model
{
    public class Groups : BaseGroup
    {
        public Category Category { get; set; }

        public virtual List<UserGroup> UserGroups { get; set; }
    }
}