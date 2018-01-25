using System.Collections.Generic;

namespace QuestMee.Model
{
    public class Post : BasePost
    {
        public UserAccount UserAccount { get; set; }
        public Thread Thread { get; set; }
        public Status Status { get; set; }


        public List<Votes> Votes { get; set; }
    }
}