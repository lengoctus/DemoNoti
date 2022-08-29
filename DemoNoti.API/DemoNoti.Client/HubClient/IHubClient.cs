namespace DemoNoti.Client.HubClient
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
