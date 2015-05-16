using System.ServiceModel;

namespace Service
{
	[ServiceContract]
	public interface IGreeterWcfService
	{
		[OperationContract]
		string Greet (string name);
	}
}
