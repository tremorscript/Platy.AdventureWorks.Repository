using AdventureWorks.Repository.Events;
using MediatR;

namespace AdventureWorks.Repository.EventHandlers;

internal class AddressCreatedHandler : INotificationHandler<AddressCreatedEvent>
{
  public Task Handle(AddressCreatedEvent notification, CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }
}
