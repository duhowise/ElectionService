using System;
using System.Collections.Generic;

namespace ElectionService.Interfaces
{
    public class PollingStation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Position> Positions { get; set; }
    }
}