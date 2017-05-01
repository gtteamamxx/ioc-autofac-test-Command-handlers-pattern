using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext _container;

        public CommandDispatcher(IComponentContext container)
        {
            _container = container;
        }

        public void Dispatch<T>(T command) where T : ICommand
        {
            if (command == null)
                return;

            var handler = _container.Resolve<ICommandHandler<T>>();
            handler.Handle(command);
        }
    }
}
