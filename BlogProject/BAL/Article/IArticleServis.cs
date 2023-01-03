namespace BlogProject.BAL;

public interface IArticleServis
{
    IList<Article> PostPost(Article article);
    IList<Article> GetPost();
    IList<Article> DeletePost(int Did);
    IList<Article> PutPost(Article modi);

}