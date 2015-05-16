# Mono WCF example

Basic example of WCF Services with Mono. WCF is *Windows Communication Foundation*. Some terminology explained:
* `Service` - class that does business logic. .NET considers a class as a WCF service when inherits from a
* `Service Contract` - interface annotated with `ServiceContract` attribute and each exposed method with `OperationContract` attribute. Those are available in the `System.ServiceModel` assembly and namespace.

## Run
* Open the `WCF.sln` file with either MonoDevelop, Xamarin Studio or Visual Studio. 
* Build the solution
* Start the solution

It should start two console applications - client and host. In the client console you can type your name and the service will greet you.

## Structure
* `Client/` Console application - consumes the service.
* `GreeterWcfService/` Class Library - the service itself. Includes business logic + contracts (interfaces) for the service.
* `Host/` Console application - hosts the WCF service via HTTP binding.
