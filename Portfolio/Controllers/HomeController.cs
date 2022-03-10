using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Misc.Services.Email_Service;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IEmailService _emailService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [HttpPost]

    public async Task<IActionResult> Feedback(string name, string email, string mobileNumber, string message)
    {
        var newMessage = new Message(new string[] {"ibneev2015@mail.ru"}, email,
            mobileNumber + name + message);
        _emailService.SendEmail(newMessage);
        Console.WriteLine("post");
        return BadRequest("All good mane");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}