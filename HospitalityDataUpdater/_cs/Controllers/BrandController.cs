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

        public string[] getSaveableData()
        {
            List<string> brandNames = new List<string>();
            foreach (Brand brand in getBrands())
            {
                brandNames.Add(brand.GetName());
            }

            string[] a = brandNames.ToArray();

            return a;
        }
        #endregion

        //Set Methods
        #region setMethods

        #endregion


        #region Methods
        public void RemoveEntry(Brand brand)
        {
            //delete this entry
            //Console.WriteLine(locations.Count);
            //Console.WriteLine("deleting entry" + location.getName());
            brands.Remove(brand);
            //Console.WriteLine(locations.Count);
        }
        public void AddEntry(Brand brand)
        {
            //adds an entry
            brands.Add(brand);
            //Console.WriteLine("added entry" + location.getName());
        }
        public void Clear()
        {
            foreach (Brand brand in brands)
            {
                brand.Clearing();
            }
            brands.Clear();
        }
        #endregion

    }
}
