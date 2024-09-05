using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UsersController(DataContext context) : BaseApiController
{
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.AppUsers.ToListAsync();
        return users;
    }

    [Authorize]
    [HttpGet("{id:int}")] //api/users/3
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var users = await context.AppUsers.FindAsync(id);
        if (users == null) return NotFound();

        return users;
    }
}
