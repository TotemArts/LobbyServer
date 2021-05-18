using System.Threading.Tasks;
using Grpc.Core;
using LobbyServer.Grpc;
using Microsoft.Extensions.Logging;

namespace LobbyServer.Services
{
    public class LobbyService : Grpc.LobbyService.LobbyServiceBase
    {
        private readonly ILogger<LobbyService> _logger;
        public LobbyService(ILogger<LobbyService> logger)
        {
            _logger = logger;
        }


        public override async Task<AuthenticateResponse> Authenticate(AuthenticateRequest request, ServerCallContext context)
        {
            return new AuthenticateResponse
            {

            };
        }

        public override async Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
        {
            return new MessageResponse
            {

            };
        }

        public override async Task receiveMessageStream(receiveMessageStreamRequest request, IServerStreamWriter<receiveMessageStreamResponse> responseStream, ServerCallContext context)
        {
            return;
        }
    }
}
