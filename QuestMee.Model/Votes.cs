namespace QuestMee.Model
{
    public class Votes : BaseVotes
    {
        public Thread Thread { get; set; }
        public Post Post { get; set; }
    }
}