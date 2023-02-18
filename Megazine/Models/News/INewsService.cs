namespace Megazine.Models.News
{
    public interface INewsService
    {
        void Delete(News demonews);
        List<News> GetAll();
        News GetById(int Id);
        List<News> GetByName(string Newsname);
        News Save(News demonews);
        News Update(News demonews);
    }
}