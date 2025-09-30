namespace Platy.AdventureWorks.Repository.Interfaces;

public interface ITrackCreated
{
  DateTimeOffset Created { get; set; }
  string? CreatedBy { get; set; }
}
