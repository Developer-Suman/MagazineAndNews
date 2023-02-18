namespace Megazine.Models.Advertisement
{
    public interface IAdvertisementService
    {
        void Delete(Advertisement demoadvertisement);
        List<Advertisement> GetAll();
        Advertisement GetById(int Id);
        List<Advertisement> GetByName(string demoname);
        Advertisement Save(Advertisement demoadvertisement);
        Advertisement Update(Advertisement demoadvertisement);
    }
}