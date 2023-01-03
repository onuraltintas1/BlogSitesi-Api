namespace BlogProject.DAL;

public class ArticleRepository : IArticleRepository
{
    public IList<Article> Articles { get; set; }
}