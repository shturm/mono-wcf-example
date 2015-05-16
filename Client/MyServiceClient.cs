using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Client
{
	public class MyServiceClient : ClientBase<IGreeterWcfService>, IGreeterWcfService
	{
		public MyServiceClient (Binding binding, EndpointAddress address) : base (binding, address)
		{
		}

		public string Greet (string name)
		{
			return Channel.Greet (name);
		}
	}
}