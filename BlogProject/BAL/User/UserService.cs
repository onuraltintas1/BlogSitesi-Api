using BlogProject.DAL;

namespace BlogProject.BAL;

public class UserService: IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public IList<User> AddUser(User user)
    {
        _userRepository.Users ??= new List<User>();
        _userRepository.Users.Add(user);
        return _userRepository.Users;
    }

    public IList<User> GetUsers()
    {
        return _userRepository.Users!;
    }
    public IList<User> DeleteUser(int Did)
    {
        User duser = _userRepository.Users.Where(x => x.Id == Did).Single<User>();
        _userRepository.Users.Remove(duser);
        duser.DeletedAt = DateTimeOffset.Now;
        return _userRepository.Users;
    }

    public IList<User> PutUser(User modif)
    {
        User puser = _userRepository.Users.Single(c => c.Id == modif.Id);
        puser.FirstName = modif.FirstName;
        puser.LastName = modif.LastName;
        puser.Username = modif.LastName;
        puser.Password = modif.Password;
        return _userRepository.Users;
    }
}