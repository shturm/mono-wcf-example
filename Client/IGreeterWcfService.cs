using System.ServiceModel;

namespace Client
{
	[ServiceContract]
	public interface IGreeterWcfService
	{
		[OperationContract]
		string Greet (string name);
	}
}