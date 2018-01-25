using System.Collections.Generic;

namespace QuestMee.Model
{
    public class UserStatus : BaseUserStatus
    {
        public List<UserAccount> UserAccounts { get; set; }
    }
}