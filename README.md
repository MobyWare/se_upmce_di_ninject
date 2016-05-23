# Goal
This is a a set .NET projects to contrast using DI with Ninject and a factory pattern. 

# Overview

I am investigating solutions to providing a concrete implementation to defined in a library to a client based a client parameter at run-time. I concluded that a factory pattern is more appropriate for run-time loading of the concrete payment class. DI allows configuration at deployment time.

# Run Samples

1. Open solution file DI_Ninject_Sample.sln in Visual Studio 2015 or later
2. Rebuild the solution

#### Factory sample
To try the factory pattern:
3. Run the web project upmce_web_processor_factory_client

You can chose one of two items from the drowndownlist and click the Process button.

#### DI Sample
To try the DI sample:
3. Open the web.config for the project upmce_web_processor_client and set to either "A" or "B".
4. Run the web projectupmce_web_processor_client and click the process button.
