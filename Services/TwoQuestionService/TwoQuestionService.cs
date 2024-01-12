
namespace NannoA_MiniChallengeTwoToFour_Endpoints.Services.TwoQuestionService;

    public class TwoQuestionService : ITwoQuestionService
{
    public string Questions2Answers(string name, string time)
    {
        return $"Hey {name} you woke up at {time}";
    }
}
