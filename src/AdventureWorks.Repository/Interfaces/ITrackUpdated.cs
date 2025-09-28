using System;

namespace Tracker.Core.Definitions;

internal interface ITrackUpdated
{
    DateTimeOffset Updated { get; set; }
    string? UpdatedBy { get; set; }
}
