using System;
using System.Collections.Generic;

namespace ElectionService.Interfaces
{
    public class Election
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public byte[] Logo { get; set; }
        public List<PollingStation> PollingStations { get; set; }
        public List<Position> Positions { get; set; }

    }
}