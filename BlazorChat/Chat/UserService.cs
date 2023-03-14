namespace BlazorChat.Chat
{
    public class UserService
    {
        private readonly Dictionary<string, string> _users = new();
        public void Add(string connectionId,string username) {
            _users[connectionId] = username;
        }

        public void RemoveByName(String username) {
        _users.Remove(username);
        }

        public string GetConnectionIdByName(string username) {
            if (_users.ContainsKey(username))
            {
                return _users[username];
            }

            return null;
        }

        public IEnumerable<(string connectionId,string username)> GetAll() {
            foreach (var kvp in _users)
            {
                yield return (kvp.Value, kvp.Key);
            }
        }


    }
}
