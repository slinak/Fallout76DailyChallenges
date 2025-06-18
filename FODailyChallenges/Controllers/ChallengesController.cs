using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FODailyChallenges.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FODailyChallenges.Controllers;

public class ChallengesController : Controller
{
    List<DailyChallenge> challenges = new List<DailyChallenge>();

    public IActionResult Index()
    {
        challenges.Add(new DailyChallenge(ChallengeType.Action, "Find books"));
        return View(challenges);
    }

    [HttpPost]
    public IActionResult Create(string _text, ChallengeType _type)
    {
        challenges.Add(new DailyChallenge(_type, _text));
        return RedirectToAction("Index");
        //return View(challenges);
    }
    
    public IActionResult Create()
    {
        return View();
    }
}