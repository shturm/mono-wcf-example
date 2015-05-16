namespace Service
{
	public class GreeterWcfService : IGreeterWcfService
	{
		public string Greet (string name)
		{
			return "Hello, " + name;
		}
	}
}