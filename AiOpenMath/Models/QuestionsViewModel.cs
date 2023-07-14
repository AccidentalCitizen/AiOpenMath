using AiOpenMath.Domain.Basic;

namespace AiOpenMath.Models
{
    public class QuestionsViewModel
    {
        public IList<string> questions { get; set; }
        public IList<string> answers { get; set; }
        public IList<string> allAnswers { get; set; }
        public IList<Pair<int, string>> allSyllabusTiems { get; set; }
        public int? noOfQuestiones {get; set;}

        public int syllabusId { get; set; }
        public int HomeWorkID { get; set; }
        public bool preview { get; set; }
    }
}
