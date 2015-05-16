using System;
using System.ServiceModel;

using Service;

namespace Host
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("WCF Host!");
			var binding = new BasicHttpBinding ();
			var address = new Uri ("http://localhost:8080");
			var host = new ServiceHost (typeof(GreeterWcfService));
			host.AddServiceEndpoint (
				typeof(IGreeterWcfService), binding, address);
			host.Open ();

			Console.WriteLine ("Type [CR] to stop...");
			Console.ReadLine ();
			host.Close ();
		}
	}
}