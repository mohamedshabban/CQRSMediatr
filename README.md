VIDEO SUMMARY:
In this video, we will briefly introduce the CQRS pattern and how the .NET library MediatR helps us build software with this architecture.

Here, we will talk about how to integrate CQRS and MediatR with the ASP.NET project and also how to use Queries. In the next video, we will cover the rest of the topics - Commands, Behaviors, and Notifications.

The MediatR library was built to facilitate two primary software architecture patterns: CQRS and the Mediator pattern. While similar, let’s spend a moment understanding the principles behind each pattern.
CQRS.

CQRS stands for “Command Query Responsibility Segregation”. As the acronym suggests, it’s all about splitting the responsibility of commands and queries into different models.
If we think about the commonly used Create-Read-Update-Delete pattern, usually we have the user interface interacting with a datastore responsible for all four operations. CQRS would instead have us split these operations into two models, one for the queries - read operations, and another for the commands - create update and delete operations.

The CQRS pattern makes no formal requirements of how this separation occurs. It could be as simple as a separate class in the same application, all the way up to separate physical applications on different servers. That decision would be based on factors such as scaling requirements and infrastructure, so we won’t go into that decision path today.
The key point is that to create a CQRS system, we just need to split the reads from the writes.
