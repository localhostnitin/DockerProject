using Microsoft.AspNetCore.SignalR;

using System.Collections.Concurrent;

namespace DockerProject.Models
{
    public class ChatHub : Hub
    {
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}

        private static ConcurrentDictionary<string, string> Users = new();

        // Call this when a user joins
        public async Task RegisterUser(string username)
        {
            Users[username] = Context.ConnectionId;
            await Clients.Caller.SendAsync("UserRegistered", username);
        }

        // Send message to a specific user
        public async Task SendPrivateMessage(string fromUser, string toUser, string message)
        {
            if (Users.TryGetValue(toUser, out var connectionId))
            {
                await Clients.Client(connectionId).SendAsync("ReceiveMessage", fromUser, message);
            }
            // Also send back to sender
            await Clients.Caller.SendAsync("ReceiveMessage", fromUser, message);
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var user = Users.FirstOrDefault(u => u.Value == Context.ConnectionId).Key;
            if (user != null) Users.TryRemove(user, out _);
            return base.OnDisconnectedAsync(exception);
        }

    }
}
