# Tinamous.Messaging.Common

This project contains common DTO classes and utilities used by most of the Tinamous services at the messaging level.

## Building:

This project is a .Net 4.x based project. It should be build with Visual Studio 2017 / MSBuild.

MSBuild Build.proj /t:Build

The primary distributable is a nuget package, use MSBuild NuGetPack.proj file with the target Package to generate the nuget package.

MSBuild NuGetPack.proj /t:Package



## NuGet:

The Nuget package will be available via an open MyGet account (coming soon...)

## License:

Non Commercial Usage: MIT License

Commercial Usage: Contact Tinamous / Analysis UK Ltd for commerical licensing.
