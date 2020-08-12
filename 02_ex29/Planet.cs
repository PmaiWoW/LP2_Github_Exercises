using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex29
{
    /// <summary>
    /// Planet Class
    /// Contains Planet's properties, constructor and 
    /// <c>GetHashCode()</c> and <c>Equals()</c> overrides
    /// </summary>
    struct Planet
    {
        /// <value>Gets the ID of the planet.</value>
        public int PlanetID { get; }
        /// <value>Gets the planet's host system's name.</value>
        public string HostSystemName { get; }
        /// <value>Gets the letter of the planet.</value>
        public char PlanetLetter { get; }
        /// <value>Gets the name of the planet.</value>
        public string PlanetName { get; }
        /// <value>Gets the discovery method of the planet.</value>
        public DiscoveryMethod DiscoveryMethod { get; }
        /// <value>Gets the orbit period of the planet, in days.</value>
        public float OrbitPeriodDays { get; }
        /// <value>Gets the distance to the planet in parsecs.</value>
        public float ParsecsDistance { get; }
        /// <value>Gets the temperature of the planet in Kelvins.</value>
        public float TempInKelvins { get; }
        /// <value>Gets the name of the planet's discovery facility.</value>
        public string DiscoveryFacility { get; }

        public Planet(int plntID, string hstSysName, char plntLtr,
            string plntName, DiscoveryMethod discMethd, float orbtPrd,
            float ParsDist, float tempKlvn, string discFclt)
        {
            PlanetID = plntID;
            HostSystemName = hstSysName;
            PlanetLetter = plntLtr;
            PlanetName = plntName;
            DiscoveryMethod = discMethd;
            OrbitPeriodDays = orbtPrd;
            ParsecsDistance = ParsDist;
            TempInKelvins = tempKlvn;
            DiscoveryFacility = discFclt;
        }

        public override int GetHashCode() => PlanetID;

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (GetHashCode() == other.GetHashCode()) return true;
            else return false;
        }

        public override string ToString() =>
            $"Planet ID: {PlanetID}, Host System: {HostSystemName}, " +
            $"Planet Letter: {PlanetLetter}, Planet Name: {PlanetName}, " +
            $"Discovery Method:: {DiscoveryMethod}, " +
            $"Orbit Period: {OrbitPeriodDays:f8} days, " +
            $"Distance in Parsecs: {ParsecsDistance:f2}, " +
            $"Temperature in Kelvins: {TempInKelvins:f2}, " +
            $"Discovery Facility: {DiscoveryFacility}";
    }
}
