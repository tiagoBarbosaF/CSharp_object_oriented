using TiagoPortal.SharedContext;

namespace TiagoPortal.SubscriptionContext
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}