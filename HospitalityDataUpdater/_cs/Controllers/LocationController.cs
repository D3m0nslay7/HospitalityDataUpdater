using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HospitalityDataUpdater._cs
{
    internal class LocationController
    {
        //vars

        List<Location> locations;

        FlowLayoutPanel locationsHolder;

        //methods relating to the locations
        EventHandler viewSocials = null;
        EventHandler editLocation = null;

        public LocationController(FlowLayoutPanel locHolder, EventHandler viewSoc, EventHandler editLoc)
        {
            locations = new List<Location>();
            setLocationHolder(locHolder);

            viewSocials = viewSoc;
            editLocation = editLoc;
        }



        //Get Methods
        #region getMethods
        public List<Location> getLocations()
        {
            return locations;
        }
        public FlowLayoutPanel getLocationHolder()
        {
            return locationsHolder;
        }

        #endregion
        //Set Methods
        #region setMethods
        public void setLocationHolder(FlowLayoutPanel locHolder)
        {
            locationsHolder = locHolder;
        }
        #endregion

        #region UI Methods

        public void CreateLocationUIs()
        {
            //first we clear the UI if locations exist
            RemoveUIs();

            //we go through the list and create the UI for each location
            foreach (Location location in locations)
            {
                location.CreateUI(viewSocials, editLocation);
            }
        }

        public void RemoveUIs()
        {
            foreach (Location location in locations)
            {
                location.ClearUI();

            }
        }

        #endregion

        #region Methods

        public void ReplaceEntry(Location oldLoc, Location newLoc)//Simple replacing method, 
        {
            //get the old locations index
            int oldLocationIndex = oldLoc.getIndex();
            //dispose of the old location now
            oldLoc.ClearUI();
            locations.Remove(oldLoc);
            //insert the new location
            locations.Insert(oldLocationIndex, newLoc);

            CreateLocationUIs();
        }

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
            RemoveUIs();
            locations.Clear();
        }
        #endregion

    }
}
