namespace QuizBattle.Domain;

public class Answer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Question Question { get; set; }
    public string ChoiceCode { get; set; }
}
