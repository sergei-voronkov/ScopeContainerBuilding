namespace TempStorage.Services
{
    public class Storage 
        : IStorage
        , ITempStorage
    {
        private readonly ILowLevelStorage lowLevelStorage;

        public Storage(ILowLevelStorage lowLevelStorage)
        {
            this.lowLevelStorage = lowLevelStorage;
        }

        public string Get(string path) =>
            this.lowLevelStorage.Get(
                path);

        public void Put(string path, string content) =>
            this.lowLevelStorage.Put(
                path, content);
    }
}