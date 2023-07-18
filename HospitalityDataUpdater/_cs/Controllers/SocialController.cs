using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalityDataUpdater._cs.Controllers
{
    internal class SocialController
    {
        //vars

        List<Social> socials;

        public SocialController()
        {
            socials = new List<Social>();
        }



        //Get Methods
        #region getMethods
        public List<Social> getSocials()
        {
            return socials;
        }
        #endregion

        #region Methods
        public void RemoveEntry(Social social) // Deletes an entry we got passed
        {
            //delete this entry
            socials.Remove(social);
        }
        public void AddEntry(Social social) // Adds the entry we got passed to the socials list
        {
            //adds an entry
            socials.Add(social);
        }
        public void Clear() // Clears the social UI's
        {
            //loops through our socials list
            foreach (Social social in socials)
            {
                //deletes the socials List
                social.ClearUI();
            }
        }

        #endregion


    }
}
