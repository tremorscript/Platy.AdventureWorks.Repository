namespace AdventureWorks.Repository.BaseEvent;

public class EntityEventBase : DomainEventBase
{
  public string JsonData { get; set; }
}
