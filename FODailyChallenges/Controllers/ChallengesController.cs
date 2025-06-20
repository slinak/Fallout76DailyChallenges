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
        return View(_dataContext.Challenges);
    }

    [HttpPost]
    public async Task<IActionResult> Create(DailyChallenge challenge)
    {
        await _dataContext.Challenges.AddAsync(challenge);
        await _dataContext.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    public IActionResult Create()
    {
        return View();
    }

    public async Task<IActionResult> Import(List<DailyChallenge> challenges)
    {
        await _dataContext.Challenges.AddRangeAsync(challenges);
        await _dataContext.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> CreateResolution(ChallengeResolution challengeResolution)
    {
        _dataContext.Resolutions.Add(challengeResolution);
        await _dataContext.SaveChangesAsync();

        return View();
    }

    //This is really more of like 'Manage and create known Resolutions'
    [HttpGet]
    public IActionResult CreateResolution(Guid challengeID)
    {
        return View(new ChallengeResolution(challengeID));
    }
}