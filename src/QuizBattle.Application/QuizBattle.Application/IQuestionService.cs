using QuizBattle.Domain;

namespace QuizBattle.Application.Interfaces
{
    public interface IQuestionService
    {
        void DisplayQuestion(Question question, int number);
        Task<Question> GetRandomQuestionAsync(CancellationToken ct = default);
        Task<List<Question>> GetRandomQuestionsAsync(int count = 3, CancellationToken ct = default);
        int PromptForAnswer(Question question);
    }
}