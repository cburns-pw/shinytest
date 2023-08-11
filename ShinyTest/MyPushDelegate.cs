using Shiny.Push;
using System.Diagnostics;

namespace ShinyTest
{
    public class MyPushDelegate : IPushDelegate
    {
        public Task OnEntry(PushNotification push)
        {
            Debug.WriteLine("OnEntry");
            return Task.CompletedTask;
        }

        public Task OnReceived(PushNotification push)
        {
            Debug.WriteLine("OnReceived");
            return Task.CompletedTask;
        }

        public Task OnTokenRefreshed(string token)
        {
            Debug.WriteLine($"OnTokenRefreshed: {token}");
            return Task.CompletedTask;
        }
    }
}
