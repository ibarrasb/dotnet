using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                 new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & pan"},
                 new Command{Id=1, HowTo="cut bread", Line="get a knife", Platform="knife & board"},
                 new Command{Id=2, HowTo="make tea", Line="place tea in cup", Platform="kettle & cup"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & pan"};
        }
    }
}