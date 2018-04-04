using System.IO;
using System.Threading.Tasks;

namespace MediatR.Examples
{
    public class JingHandler : RequestHandler<Jing>
    {
        private readonly TextWriter _writer;

        public JingHandler(TextWriter writer)
        {
            _writer = writer;
        }

        protected override Task Handle(Jing request)
        {
            return _writer.WriteLineAsync($"--- Handled Jing: {request.Message}, no Jong");
        }
    }
}
