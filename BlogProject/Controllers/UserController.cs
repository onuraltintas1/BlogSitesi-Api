using BlogProject.BAL;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    private IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet("GetUsers")]
    public IEnumerable<User> GetUsers()
    {
        return _userService.GetUsers();
    }

    [HttpPost("AddUser")]
    public IEnumerable<User> AddUser([FromBody] User user)
    {
        return _userService.AddUser(user);
    }
    [HttpDelete("DeletePost")]
    public IEnumerable<User> DeletePost(int id)
    {
        return _userService.DeleteUser(id);
    }

    [HttpPut("PutPost")]
    public IEnumerable<User> PutPost(User id)
    {
        return _userService.PutUser(id);
    }
}