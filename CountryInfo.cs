using System.Collections.Generic;

namespace TestDapper.Models
{
    public class CountryInfo
    {
        public int countryId { get; set; }
        public string countryName { get; set; }

        public List<StateInfo> States { get; set; }
        public StateInfo State { get; set; }
    }

    public class StateInfo
    {
        public int stateId { get; set; }
        public string stateName { get; set; }
        public int countryId { get; set; }
    }
}
