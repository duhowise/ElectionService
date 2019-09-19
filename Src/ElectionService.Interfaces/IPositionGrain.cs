using System;
using System.Threading.Tasks;
using Orleans;

namespace ElectionService.Interfaces
{
    public interface IPositionGrain:IGrainWithGuidKey
    {
        Task AddPositionAsync(Guid electionId,Position position);
        Task AddPositionToPollingStationAsync(Guid pollingStationId,Position position);
        Task RemovePositionAsync(Guid positionId);
        Task UpdatePositionAsync(Guid positionId,UpdatePosition update);
    }

    public class UpdatePosition
    {
    }
}