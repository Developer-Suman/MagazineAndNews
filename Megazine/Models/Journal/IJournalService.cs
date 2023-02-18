namespace Megazine.Models.Journal
{
    public interface IJournalService
    {
        void Delete(Journal demojournal);
        List<Journal> GetAll();
        Journal GetById(int Id);
        Journal GetSingleData(int Id);
        List<Journal> GetByName(string demoname);
        Journal Save(Journal demojournal);
        Journal Update(Journal demojournal);
    }
}