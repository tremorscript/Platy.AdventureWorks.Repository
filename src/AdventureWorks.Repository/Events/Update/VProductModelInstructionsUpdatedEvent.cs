using System;
using System.Collections.Generic;
using AdventureWorks.Repository.BaseEvent;

namespace AdventureWorks.Repository.Events;

/// <summary>
/// Event class representing the data when changes are made to the table 'vProductModelInstructions'.
/// </summary>
public class VProductModelInstructionsUpdatedEvent
    : EntityEventBase
{
}
