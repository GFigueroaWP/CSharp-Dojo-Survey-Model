using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurveyModel.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Survey(Survey survey)
    {
        return View(survey);
    }

}