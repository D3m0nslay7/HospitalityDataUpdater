using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalityDataUpdater._cs
{
    internal class LocationController
    {
        //vars

        List<Location> locations;

        public LocationController()
        {
            locations = new List<Location>();
        }



        //Get Methods
        #region getMethods
        public List<Location> getLocations()
        {
            return locations;
        }
        #endregion

        //Set Methods
        #region setMethods

        #endregion


        #region Methods
        public void RemoveEntry(Location location)
        {
            //delete this entry
            //Console.WriteLine(locations.Count);
            //Console.WriteLine("deleting entry" + location.getName());
            locations.Remove(location);
            //Console.WriteLine(locations.Count);
        }
        public void AddEntry(Location location)
        {
            //adds an entry
            locations.Add(location);
            //Console.WriteLine("added entry" + location.getName());
        }
        public void Clear()
        {
            foreach (Location location in locations)
            {
                location.Clearing();
                
            }
            locations.Clear();
        }
        #endregion

    }
}
