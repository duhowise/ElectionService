using Orleans;
using System;
using System.Threading.Tasks;

namespace ElectionService.Interfaces
{
    public interface IElectionGrain:IGrainWithGuidKey
    {
        Task RegisterElection(Election election);
        Task StartElection(Guid id);
        Task StopElection(Guid id);
        Task DisableElection(Guid id);
        Task EnableElection(Guid id);
        Task VerifyElection(Guid id);


    }
}
