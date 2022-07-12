namespace TempStorage.Services
{
    public interface ILowLevelStorage
    {
        string Get(string path);
        void Put(string path, string content);
    }
}