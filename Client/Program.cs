// Client
using System;
using System.ServiceModel;

namespace Client
{
	public class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("WCF Client\n");
			string name = "";
			var binding = new BasicHttpBinding ();
			var address = new EndpointAddress ("http://localhost:8080");
			var client = new MyServiceClient (binding, address);


			while (true) {
				Console.Write("\nEnter name: ");
				name = Console.ReadLine ();

				Console.WriteLine ("Service response: " + client.Greet (name));
			}
		}
	}
}

