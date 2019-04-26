# Tinamous.Messaging.Common

This project contains common DTO classes and utilities used by most of the Tinamous services at the messaging level.

Messaging DTO's are used across the range of service communications, by EasyNetQ / RabbitMQ, AWS SNS/SQS, Kinesis and more. Classes in this project may be used in various ways and should stick to simple POCO's.

## Building:

This project is a .Net 4.x based project. It should be build with Visual Studio 2017 / MSBuild.

MSBuild Build.proj /t:Build

The primary distributable is a nuget package, use MSBuild NuGetPack.proj file with the target Package to generate the nuget package.

MSBuild NuGetPack.proj /t:Package


## Consuming:

The Nuget package is available via the Tinamous MyGet feed: https://www.myget.org/F/tinamous/api/v3/index.json

## License:

Non Commercial Usage: MIT License

Commercial Usage: Contact Tinamous / Analysis UK Ltd for commerical licensing.


## Notes:

Tinamous source code available on GitHub has no history from the initial GitHub push, this is to ensure a clean break from the previous private development and reduce the risk of crediential leakages.
