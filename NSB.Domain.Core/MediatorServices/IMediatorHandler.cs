using System.Threading.Tasks;
using MediatR;

namespace NSB.Domain.Core.MediatorServices
{
    interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : INotification;
        Task Publish<T>(T notification) where T : INotification;
    }
}