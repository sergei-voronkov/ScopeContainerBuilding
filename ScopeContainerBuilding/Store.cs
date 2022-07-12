namespace ScopeContainerBuilding
{
    using System;

    public class Store
    {
        public readonly string Name;

        public Store()
        {
            this.Name = "Global";
        }

        public Store(string name)
        {
            this.Name = name;
        }

        public void Write()
        {
            Console.WriteLine(
                $"[{this.Name}] Store.Write");
        }
    }
}