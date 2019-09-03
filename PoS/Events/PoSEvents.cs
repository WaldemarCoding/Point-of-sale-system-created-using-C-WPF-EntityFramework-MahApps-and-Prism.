using PoS.Dal.Mdl;
using Prism.Events;

namespace PoS.Events
{
	public class UserLoginEvent : PubSubEvent<User>
	{
	}

	public class UserLogoutEvent : PubSubEvent
	{
	}
}
