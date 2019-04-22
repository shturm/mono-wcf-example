buildHost:
	csc GreeterWcfService/IGreeterWcfService.cs GreeterWcfService/GreeterWcfService.cs -target:library
	csc Host/Program.cs -reference:IGreeterWcfService.dll -out:Host.exe

runHost:buildHost
	mono Host.exe
	rm IGreeterWcfService.dll

buildClient:
	csc Client/IGreeterWcfService.cs Client/MyServiceClient.cs Client/Program.cs -out:Client.exe

runClient: buildClient
	mono Client.exe

