using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FODailyChallenges.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FODailyChallenges.Controllers;

public class ChallengesController : Controller
{
    private readonly ChallengesDBContext _dataContext;

    public ChallengesController(ChallengesDBContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IActionResult Index()
    {
        return View(_dataContext.Challenge);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ChallengeType _type, string _text)
    {
        DailyChallenge dailyChallenge = new DailyChallenge(_type, _text);
        _dataContext.Challenge.Add(dailyChallenge);
        await _dataContext.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateResolution()
    {
        return View();
    }

    //This is really more of like 'Manage and create known Resolutions'
    [HttpGet]
    public IActionResult CreateResolution(string challengeID)
    {
        return View();
    }
}