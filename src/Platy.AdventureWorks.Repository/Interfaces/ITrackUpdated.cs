namespace Platy.AdventureWorks.Repository.Interfaces;

internal interface ITrackUpdated
{
  DateTimeOffset Updated { get; set; }
  string? UpdatedBy { get; set; }
}
