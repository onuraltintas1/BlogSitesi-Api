namespace BlogProject.DAL;

public class UserRepository : IUserRepository
{
    public IList<User>? Users { get; set; }
}