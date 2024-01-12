

namespace NannoA_MiniChallengeTwoToFour_Endpoints.Services.AddService;

public class AddService : IAddService
{
    public string Add2Numbers(double number1, double number2)
    {
        return $"The sum of {number1} and {number2} is = {number1 + number2}";
    }
}
