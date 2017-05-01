using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Command;
using WpfApp1.Command.Something;

namespace WpfApp1.Handlers
{
    public class SomethingHandler : ICommandHandler<SomethingCommand>
    {
        public void Handle(SomethingCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
