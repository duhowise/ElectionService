using System;

namespace ElectionService.Interfaces
{
    public class Position
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PollingStationId { get; set; }
        public PollingStation PollingStation { get; set; }
    }
}