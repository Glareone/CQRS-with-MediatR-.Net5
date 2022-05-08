# CQRS-with-MediatR
CQRS using MediatR library and latest .NetCore along with C#9.

# Initial Information
Very useful in 2 cases:
1. Read\Write operations - in case, when you need to split read and write operations and you have much more Read operations over Write.
2. Notifications - in case, when you need to call several independent handlers (for example, send an email after entity creation or invalidate cache).
3. Logic Decoupling - in case you want to decouple write operations and read, or even to point these operations to different storages

More about good and bad reasons are here: [3 Reasons for and 1 against](https://codeopinion.com/why-use-mediatr-3-reasons-why-and-1-reason-not/)

More information is here: [CQRS and MediatR in ASP.NET Core](https://code-maze.com/cqrs-mediatr-in-aspnet-core/)

![initial map](https://user-images.githubusercontent.com/4239376/167310667-8e724eab-13b0-4acc-b114-c04f535362ac.png)
![mediator call structure](https://user-images.githubusercontent.com/4239376/167311360-6297094a-eb4d-4d1e-ae20-2bc6b965036f.png)


# Project structure
1. Main API project
2. Common project which contains some code which could be shared among projects
3. Simple Repository project which fakes DB

# Used Tools
* .Net 5 - latest stable .Net version, C#10  
* MediatR - package which implements Mediator patterns  
* .editorConfig - for style rules  
* Automapper - map entities  
