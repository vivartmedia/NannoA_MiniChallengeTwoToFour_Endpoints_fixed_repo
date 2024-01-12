
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeTwoToFour_Endpoints.Services.CompNumService;


namespace NannoA_MiniChallengeTwoToFour_Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class Compair2NumbersController : ControllerBase
{
    private readonly ICompNumService _compNumService;

    public Compair2NumbersController(ICompNumService CompNumService)
    {
        _compNumService = CompNumService;
    }

    [HttpGet]
    [Route("GreaterOrLess/{numOne}/{numTwo}")]

    public string GreaterOrLess(double numOne, double numTwo)
    {
        return _compNumService.GreaterOrLess(numOne, numTwo);
    }
}
