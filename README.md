# ASP.NET Core Web API Hello World App

This repo shows a very simple hello world API on ASP.NET Core 2.0, running dockerized.

## To Run
```
$ docker build -t dotnet-helloworld .
$ docker run -d -p 1234:80 dotnet-helloworld
```
then navigate to port 1234
