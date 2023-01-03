namespace BlogProject.DAL;

public interface IArticleRepository
{
    public IList<Article> Articles { get; set; }

}