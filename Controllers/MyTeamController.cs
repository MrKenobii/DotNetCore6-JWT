using System;
using JwtBasics.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtBasics.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MyTeamController : ControllerBase
{
    private ITeamRepository _iteamRepo;
    public MyTeamController(ITeamRepository teamRepository)
    {
        this._iteamRepo = teamRepository;
    }
    [HttpGet]
    [Authorize]
    public IActionResult GetTeamMembers()
    {
        var teamMembers = _iteamRepo.getTeamMembers();
        return Ok(teamMembers);
    }
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate(string userName, string password)
    {
        var user = _iteamRepo.Authenticate(userName, password);
        if (user == null)
        {
            return BadRequest(new { message = "Username or password is incorrect" });
        }
        return Ok(user);
    }

}


