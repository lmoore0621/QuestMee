using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseUserAccount : BaseEntity
    {
        public int UserStatusId { get; set; }


        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CreatedTime { get; set; }
        public byte[] Picture { get; set; }
        public virtual string LastActivity { get; set; }
        public bool IsModerator { get; set; }
        public string Status { get; set; }
    }
}