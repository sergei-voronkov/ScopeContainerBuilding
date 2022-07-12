namespace TempStorage.Services
{
    public interface IStorage
    {
        string Get(string path);
        void Put(string path, string content);
    }
}