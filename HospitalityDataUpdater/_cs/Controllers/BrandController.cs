using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalityDataUpdater._cs.Controllers
{
    internal class BrandController
    {
        //vars
        List<Brand> brands;

        //Constructer
        public BrandController()
        {
            brands = new List<Brand>();
        }



        //Get Methods
        #region getMethods
        public List<Brand> getBrands()
        {
            return brands;
        }

        //Method that returns the brands in a serlized json array
        public string getSaveableData()
        {
            //create a list of strings
            List<string> brandNames = new List<string>();
            //loop through the current brand classes in our brand list
            foreach (Brand brand in getBrands())
            {
                //add each name into the list of brandNames
                brandNames.Add(brand.GetName());
            }
            //convert the list of brandnames into a serialzied jsonarray, meaning we can now save it in excel
            string jsonArray = JsonConvert.SerializeObject(brandNames);
            //return our serlized array
            return jsonArray;
        }
        #endregion

        #region Methods
        public void RemoveEntry(Brand brand)
        {
            //delete the entry we got from whatever called this method
            brands.Remove(brand);
        }
        public void AddEntry(Brand brand)
        {
            //adds an entry we recived to our brands list
            brands.Add(brand);
        }
        public void Clear() // used to clear the brands list
        {
            //loop through the brands list
            foreach (Brand brand in brands)
            {
                //call clearui, which will delete the ui
                brand.ClearUI();
            }
            //we empty the list now
            brands.Clear();
        }
        #endregion

    }
}
