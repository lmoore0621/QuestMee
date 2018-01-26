namespace QuestMee.Model
{
    public class UserGroup : BaseUserGroup
    {
        public virtual UserAccount UserAccount { get; set; }
        public virtual Groups Group { get; set; }
    }
}