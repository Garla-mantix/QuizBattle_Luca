namespace QuizBattle.Domain;

public class QuizSession
{
    // Identifierar denna quiz session
    public Guid Id { get; set; }

    // starttid för denna quiz session
    public DateTime StartedAtUtc { get; set; }

    // tiden då denna quiz session avslutades 
    public DateTime? FinishedAtUtc { get; set; }

    // QuestionCount
    public int QuestionCount { get; set; }

    // Answers
    public List<Answer> Answers { get; set; } = new List<Answer>();

    // Score
    public int Score => Answers.Where(answer => answer.Question.CorrectAnswerCode == answer.ChoiceCode).Count();

    // Start()

    // SubmitAnswer()

    // Finish()
}
