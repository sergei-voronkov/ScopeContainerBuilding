namespace TempStorage.Services
{
    public class Render : IRender
    {
        private readonly IStorage storage;
        private readonly ITempStorage tempStorage;

        public Render(IStorage storage, ITempStorage tempStorage)
        {
            this.storage = storage;
            this.tempStorage = tempStorage;
        }

        public void DoRender()
        {
            this.storage.Get(
                "path to Data for rendering");

            this.tempStorage.Put(
                "path for rendering results",
                "rendering results.");
        }
    }
}
