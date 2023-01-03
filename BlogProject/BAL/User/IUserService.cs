namespace BlogProject.BAL;

public interface IUserService
{
    IList<User> GetUsers();
    IList<User> AddUser(User user);
    IList<User> DeleteUser(int Did);
    IList<User> PutUser(User modif);
}