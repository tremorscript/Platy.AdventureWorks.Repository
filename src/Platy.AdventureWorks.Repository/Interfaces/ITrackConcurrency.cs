namespace Platy.AdventureWorks.Repository.Interfaces;

public interface ITrackConcurrency
{
    string RowVersion { get; set; }
}
