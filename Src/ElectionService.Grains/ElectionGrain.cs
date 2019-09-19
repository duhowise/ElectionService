using System;
using System.Threading.Tasks;
using ElectionService.Interfaces;
using Orleans;

namespace ElectionService.Grains
{
    public class ElectionGrain:Grain,IElectionGrain
    {
        public Task RegisterElection(Election election)
        {
            throw new NotImplementedException();
        }

        public Task StartElection(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task StopElection(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DisableElection(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EnableElection(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task VerifyElection(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
