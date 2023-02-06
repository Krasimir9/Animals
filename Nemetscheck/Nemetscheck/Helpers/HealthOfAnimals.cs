using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Repository.Contarcts;

namespace Nemecheck.Commands
{
    public class ShowHealth : Command
    {
        public ShowHealth(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository)
            : base(parameters, database, repository)
        {
        }
        public override string Execute()
        {
            int health = 0;
            //I am not sure if you want the minimal health or hot but that's the way I undestand it.
            //I take the count of bears and multyply it by 65(which is the minimal health of the bear before dyeing according to the task).
            if (this.Parameters[0] == "Bears")
            {
                var bears = this.Database.Bears.Where(x => x.IsDead == false).ToList();
                health = bears.Count * 65;
            }
            else if (this.Parameters[0] == "Wolves")
            {
                var wolves = this.Database.Wolfs.Where(x => x.IsDead == false).ToList();
                health = wolves.Count * 60;
            }
            else if (this.Parameters[0] == "Rabits")
            {
                var rabits = this.Database.Rabits.Where(x => x.IsDead == false).ToList();
                health = rabits.Count * 40;
            }
            return $"The sum of all living {Parameters[0]} health is : {health}.";
        }
    }
}
