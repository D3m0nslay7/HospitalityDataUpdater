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

        //Constructor
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
                //call, create ui and we send the event handlers we have stored
                location.CreateUI(viewSocials, editLocation);
            }
        }
        
        public void RemoveUIs() // Method to delete all UI for locations, but not delete them
        {
            //loop through the locations list
            foreach (Location location in locations)
            {
                //calls clear on each individual location, clearing the data
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
            //create the UI for the locations now
            CreateLocationUIs();
        }

        public void RemoveEntry(Location location) // Deletes the location we got
        {
            //delete this entry
            locations.Remove(location);
        }
        public void AddEntry(Location location) // Adds a entry
        {
            //adds an entry
            locations.Add(location);
        }

        public void Clear() // Clears the entire location controller
        {
            //removes all UI's of the locations stored
            RemoveUIs();
            //clears the list
            locations.Clear();
        }
        #endregion

    }
}
