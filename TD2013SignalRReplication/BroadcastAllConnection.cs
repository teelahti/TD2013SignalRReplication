namespace TD2013SignalRReplication
{
    using Microsoft.AspNet.SignalR;

    public class BroadcastAllConnection : PersistentConnection
    {
        protected override System.Threading.Tasks.Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }
}