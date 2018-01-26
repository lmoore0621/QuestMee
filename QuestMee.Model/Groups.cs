using System.Collections.Generic;

namespace QuestMee.Model
{
    public class Groups : BaseGroup
    {
        public Category Category { get; set; }


        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}