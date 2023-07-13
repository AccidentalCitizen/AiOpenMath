namespace AiOpenMath.Models
{
    public class QuestionsViewModel
    {
        public IList<string> questions { get; set; }
        public IList<string> answers { get; set; }
        public int HomeWorkID { get; set; }
        public bool preview { get; set; }
    }
}
