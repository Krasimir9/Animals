using Nemetscheck.Animals;

namespace Nemetscheck.Database
{
    public interface IInMemoryDataBase
    {
        List<Wolf> Wolfs { get; }

        List<Bear> Bears { get; }

        List<Rabit> Rabits { get; }

        List<BaseAnimal> Animals { get; }
    }
}
