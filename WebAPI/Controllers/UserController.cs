using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserServise _userServise;
    [HttpGet("GetUsers")]
    public List<User> GetUsers()
    {
        return _userServise.GetUsers();
    }
    [HttpGet("GetUser")]
    public User GetUser(int id)
    {
        return _userServise.GetUser(id);
    }
    [HttpPost("AddUser")]
    public string AddUser(User user)
    {
        return _userServise.AddUser(user);
    }
    [HttpDelete("DeleteUser")]
    public string DeleteUser(int id)
    {
        return _userServise.DeleteUser(id);
    }
    [HttpPut("UpdateUser")]
    public string UpdateUser(User user)
    {
        return _userServise.UpdateUser(user);
    }
}
