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

        //Set Methods
        #region setMethods

        #endregion


        #region Methods
        public void RemoveEntry(Social social)
        {
            //delete this entry
            //Console.WriteLine(locations.Count);
            //Console.WriteLine("deleting entry" + location.getName());
            socials.Remove(social);
            //Console.WriteLine(locations.Count);
        }
        public void AddEntry(Social social)
        {
            //adds an entry
            socials.Add(social);
            //Console.WriteLine("added entry" + location.getName());
        }
        public void Clear()
        {
            foreach (Social social in socials)
            {
                social.Clearing();

            }
        }

        #endregion


    }
}
