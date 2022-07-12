namespace ScopeContainerBuilding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Recognizer
    {
        public readonly Store store;

        public Recognizer(Store store)
        {
            this.store = store;
        }

        public void Recognize()
        {
            this.store.Write();
        }
    }
}
