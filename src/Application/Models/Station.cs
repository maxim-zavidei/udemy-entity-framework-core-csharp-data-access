using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Models
{
    public class Station : Entity
    {
        public List<StationsAssemblySteps> StationAssemblySteps { get; set; }
        public Round Round { get; set; }
        public string Position { get; set; }
    }
}