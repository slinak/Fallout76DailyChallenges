using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FODailyChallenges.Models;
using System.Collections.Generic;
using System;
using System.Linq;

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
        var challenges = _dataContext.Challenge;
        return View(challenges);
    }

    [HttpPost]
    public IActionResult Create(string _text, ChallengeType _type)
    {
        //challenges.Add(new DailyChallenge(_type, _text));
        return RedirectToAction("Index");
        //return View(challenges);
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