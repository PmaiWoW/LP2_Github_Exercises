using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex29
{
    struct Planet
    {
        int PlanetID { get; }
        string HostSystemName { get; }
        char PlanetLetter { get; }
        string PlanetName { get; }
        DiscoveryMethod DiscoveryMethod { get; }
        float OrbitPeriodDays { get; }
        float ParsecsDistance { get; }
        float TempInKelvins { get; }
        string DiscoveryFacility { get; }

        public override int GetHashCode() => PlanetID;

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (GetHashCode() == other.GetHashCode()) return true;
            else return false;
        }
    }
}
