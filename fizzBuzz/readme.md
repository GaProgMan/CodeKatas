# Add xunit

At the time of recording/streaming, there is an issue with xunit 2.3.0 and .NET Core 2.1.301 (i.e. 2.1). Take a look at my GitHub issue for [adding unit tests to dwCheckApi](https://github.com/GaProgMan/dwCheckApi/issues/4) for an example of what happens.

It's a known issue, and there is a workaround. But we're going to use the [recommended fix](https://github.com/xunit/xunit/issues/1675) - which is to use the current build on MyGet.

We do that by running the following command:

`dotnet add package xunit --version 2.4.0-beta.3.build4034  -s https://www.myget.org/F/xunit/api/v3/index.json`

If you're watchin this in the future (i.e. after 2.4.0 of xunit is released), then you wont have to do this.

## What I've Done

I've created two projects:

- src
- tests

The src project is a .NET Standard 2.0 class library, and the tests project is a .NET Core 2.1 application with the xunit library added (and a reference to our src library).

## Running The Tests

Assuming that you have a console open in the tests directory, you can issue the following command to run the tests:

`dotnet xunit`

You _may_ need to run a restore in order to make sure that you have the latest code from the src project. You can do this by running the following command (again from the tests directory):

`dotnet restore`