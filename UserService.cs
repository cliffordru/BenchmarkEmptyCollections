using System.Collections.ObjectModel;

namespace EmptyCollections
{
    /*
     * Want to avoid returning null collections as then you have to check/guard for null reference exceptions
     * Better to return an empty collection but memory will be allocated if you use return new List<User>(); 
     * Enumerable.Empty is an option
     * However read-only lists, dictionaries, etc. were not possible until now, .NET 8
     */

    public record User(string FullName);

    public class UserService
    {
        public IReadOnlyCollection<User> GetUsers()
        {
            return ReadOnlyCollection<User>.Empty;
        }

        public IDictionary<int, User> GetUsersDictionary()
        {
            return ReadOnlyDictionary<int, User>.Empty;
        }
    }
}
