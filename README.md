# Mono WCF example

Basic example of WCF Services with Mono. WCF is *Windows Communication Foundation*.
![Mono WCF example](https://raw.githubusercontent.com/shturm/mono-wcf-example/master/mono-wcf.png)
Some terminology explained:
* `Service` - class that does business logic. .NET considers a class as a WCF service when inherits from a
* `Service Contract` - interface annotated with `ServiceContract` attribute and each exposed method with `OperationContract` attribute. Those are available in the `System.ServiceModel` assembly and namespace.
* `Host` - application that hosts the WCF Service. Typically this is IIS. You can tell IIS "This DLL has a WCF Service - host it for me" and it will. But .NET includes necessary classes for you to host it in another application (like in this repository).
* `ServiceHost` - .NET class from `System.ServiceModel` that can start hosting specified services. It's used to run the service in custom applications, like this.
* `Binding` - Class representing the protocol for hosting the service. E.g. HTTP, TCP, etc. This example runs with HTTP binding. A `Binding` object is passed to the `ServiceHost` constructor.

## Run
* Open the `WCF.sln` file with either MonoDevelop, Xamarin Studio or Visual Studio.
* Build the solution
* Start the solution

It should start two console applications - client and host. In the client console you can type your name and the service will greet you.

## Structure
* `Client/` Console application - consumes the service.
* `GreeterWcfService/` Class Library - the service itself. Includes business logic + contracts (interfaces) for the service.
* `Host/` Console application - hosts the WCF service via HTTP binding.
