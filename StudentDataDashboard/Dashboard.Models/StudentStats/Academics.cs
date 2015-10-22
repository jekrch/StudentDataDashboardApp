namespace PFdata.Dashboard.Models.StudentStats
{
    public class Academics
    {
        public string ScoreType { get; set; }
        public decimal Score { get; set; }

        public int HomeworkCompletionScore { get; set; }
        public bool HomeworkCompletionScoreCheck { get; set; }
        public bool ScoreCheck { get; set; }

        public string ScoreDate { get; set; }
    }
}