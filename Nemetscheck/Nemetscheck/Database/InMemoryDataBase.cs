using Nemetscheck.Animals;

namespace Nemetscheck.Database
{
    public class InMemoryDataBase : IInMemoryDataBase
    {
        public InMemoryDataBase()
        {
            this.Wolfs = new List<Wolf>();
            this.Rabits = new List<Rabit>();
            this.Bears = new List<Bear>();
            this.Animals = new List<BaseAnimal>();
        }

        public List<Wolf> Wolfs { get; }

        public List<Bear> Bears { get; }

        public List<Rabit> Rabits { get; }

        public List<BaseAnimal> Animals { get; }
    }
}
