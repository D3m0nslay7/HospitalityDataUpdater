using HospitalityDataUpdater._cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HospitalityDataUpdater._cs.Controllers;
using Newtonsoft.Json;
using ExcelDataReader;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HospitalityDataUpdater
{
    public partial class MainMenu : Form
    {
        //data
        DataTable importedData;
        int currentRow;
        int maxRow;
        //containers
        public FlowLayoutPanel locationsContainer;
        public FlowLayoutPanel socialsContainer;
        public FlowLayoutPanel brandsContainer;
        //controllers
        LocationController locController;
        SocialController currentSocController;
        BrandController brandController;


        public MainMenu()
        {
            InitializeComponent();
            FilePathTextbox.Text = "C:\\Users\\D3m0n\\Desktop\\asda.xlsx";
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //setup
            #region setup
            //here we get the containers for the UI
            locationsContainer = this.Controls.Find("LocationFlowLayout", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            socialsContainer = this.Controls.Find("SocialsLayoutContainer", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            brandsContainer = this.Controls.Find("BrandsFlowLayout", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            #endregion

            #region testing
            for (int i = 0; i < -1; i++)
            {
                //Location loc = new Location(i, "test"+i, "webste"+i, "231" + i, "awdawdawdwad" + i, "awdfafawfawfawfawfwam" + i, "london" + i, "232232" + i,  locController, locationsContainer); // Create a new Location instance for each array element

                //locController.AddEntry(loc);
            }

            for (int i = 0; i < -1; i++)
            {
                Brand brand = new Brand(i, "brand" + i, brandController, brandsContainer);

                brandController.AddEntry(brand);
            }
            #endregion

            #region excel


            #endregion
        }




        public void SetData(DataRow row)//set the data, when we get the data
        {
            string temp;
            //we import the data now

            //get new controllers, we dont want any old data
            //here we get the controlelrs
            locController = new LocationController();
            currentSocController = new SocialController();
            brandController = new BrandController();

            //company name
            CompanyNameLabel.Text = "Company Name: " + row["Company"].ToString();
            //website
            WebsiteInput.Text = row["Website"].ToString();
            //new stores
            if (row["New_Num_Stores"].ToString() == string.Empty)
            {
                NumNewStoresInput.Value = 0;
            }
            else
            {
                NumNewStoresInput.Value = Convert.ToInt32(row["New_Num_Stores"].ToString());
            }
            //developing stores
            if (row["Num_Developing_Stores"].ToString() == string.Empty)
            {
                NumDevStoresInput.Value = 0;
            }
            else
            {
                NumDevStoresInput.Value = Convert.ToInt32(row["Num_Developing_Stores"].ToString());
            }
            //bookings
            BookingsProviderInput.Text = row["Bookings_provider"].ToString();
            //brands
            string[] brands = JsonConvert.DeserializeObject<string[]>(row["Brands"].ToString());
            if (brands != null)
            {
                for (int i = 0; i < brands.Length; i++)
                {
                    Brand brand = new Brand(i, brands[i], brandController, brandsContainer);

                    brandController.AddEntry(brand);
                }
            }


            //locations in a dictionary
            var locations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(row["Locations"].ToString());
            //loop through each location, and create one and put it in locationscontainer
            if (locations != null)
            {
                int z = 0;
                foreach (var data in locations)
                {

                    string key = data.Key; // Get the outer dictionary key
                    Dictionary<string, object> innerDict = data.Value; // Get the inner dictionary data

                    // Access the "location_socials" inner object
                    JObject locationSocialsObject = (JObject)innerDict["location_socials"];

                    //first we setup the socials
                    SocialController socCont = new SocialController();
                    Dictionary<string, object> locationSocials = locationSocialsObject.ToObject<Dictionary<string, object>>();


                    int p = 0;
                    foreach (var socialData in locationSocials)
                    {
                        string platform = socialData.Key; // e.g., "instagram", "twitter", "Facebook"
                        object obj = socialData.Value; // the value associated with the platform

                        if (obj != null)
                        {
                            string tag = obj.ToString();
                            Social social = new Social(p, platform, tag, socCont, socialsContainer);

                            socCont.AddEntry(social);
                            p++;
                        }


                    }
                    string locName = "";
                    string locadd1 = "";
                    string locadd2 = "";
                    string locCity = "";
                    string locPost = "";
                    string locPho = "";
                    string locWeb = "";
                    if (innerDict["location_name"] != null)
                    {
                        locName = innerDict["location_name"].ToString();
                    }
                    if (innerDict["location_address_1"] != null)
                    {
                        locadd1 = innerDict["location_address_1"].ToString();
                    }
                    if (innerDict["location_address_2"] != null)
                    {
                        locadd2 = innerDict["location_address_2"].ToString();
                    }
                    if (innerDict["location_city"] != null)
                    {
                        locCity = innerDict["location_city"].ToString();
                    }
                    if (innerDict["location_postcode"] != null)
                    {
                        locPost = innerDict["location_postcode"].ToString();
                    }
                    if (innerDict["location_phone"] != null)
                    {
                        Console.WriteLine(innerDict["location_phone"]);
                        locPho = innerDict["location_phone"].ToString();
                    }
                    if (innerDict["location_website"] != null)
                    {
                        locWeb = innerDict["location_website"].ToString();
                    }


                    // now we import the locations
                    Location loc = new Location(z, locName, locWeb, locPho, locadd1, locadd2, locCity, locPost, socCont, locController, locationsContainer, viewSocialsButton_Click); // Create a new Location instance for each array element

                    locController.AddEntry(loc);

                    z++;
                }
            }


        }

        #region UI Methods

        private void ImportButton_Click(object sender, EventArgs e)
        {
            //get the desired rows
            int from = Convert.ToInt32(FromRowDropDown.SelectedItem);
            int to = Convert.ToInt32(ToRowDropDown.SelectedItem);

            //bit of validation here
            if (from > to)
            {
                MessageBox.Show("The row on the left is bigger then the row on the right.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //imports
            importedData = Import(from, to);

            for (int i = 0; i < importedData.Rows.Count; i++)
            {
                RowChooserDropDown.Items.Add(i);
            }
            currentRow = 0;
            maxRow = importedData.Rows.Count;
            SetData(importedData.Rows[currentRow]);
            MessageBox.Show("Successfully inserted data");
        }



        private void FilePathTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter key was pressed

                string enteredValue = FilePathTextbox.Text;
                int rows = GetExcelRowCount(enteredValue);

                for (int i = 0; i < rows; i++)
                {
                    FromRowDropDown.Items.Add(i);
                    ToRowDropDown.Items.Add(i);
                   
                }

                MessageBox.Show("Successfully got the rows for the file, choose what u want to insert");
            }
        }
        #endregion

        #region excel

        public void saveFile()
        {

        }
        private DataTable Import(int startRow, int endRow) // used to import the data we want
        {
            if (importedData != null)
            {
                clearEntries();
            }

            string filePath = FilePathTextbox.Text; // get the filepath from the ui

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
                    });

                    DataTable dataTable = result.Tables[0];

                    // Filter the rows within the desired range
                    DataTable filteredTable = dataTable.AsEnumerable()
                        .Skip(startRow - 1)
                        .Take(endRow - startRow + 1)
                        .CopyToDataTable();

                    return filteredTable;
                }
            }
        }
        public int GetExcelRowCount(string filePath) // used to retrieve the amount of rows
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
                    });

                    DataTable dataTable = result.Tables[0];
                    int rowCount = dataTable.Rows.Count;

                    return rowCount;
                }
            }
        }
        #endregion


        public void saveEntries()
        {
            //we save all the entries into the row
            importedData.Rows[currentRow]["Website"] = WebsiteInput.Text;
            importedData.Rows[currentRow]["New_Num_Stores"] = NumNewStoresInput.Value;
            importedData.Rows[currentRow]["Num_Developing_Stores"] = NumDevStoresInput.Value;
            importedData.Rows[currentRow]["Bookings_provider"] = BookingsProviderInput.Text;
            importedData.Rows[currentRow]["Brands"] = brandController.getSaveableData();


            //locations in a dictionary
            Dictionary<string, object> locationsData = new Dictionary<string, object>();

            //loop through each location, and create one and put it in locationscontainer
            if (locController.getLocations().Count > 0)
            {
                int z = 1;
                foreach (Location data in locController.getLocations())
                {

                    Dictionary<string, object> locationData = new Dictionary<string, object>();

                    //first we setup the socials
                    SocialController socCont = data.getSocials();
                    Dictionary<string, object> locationSocials = new Dictionary<string, object>();


                    int p = 0;
                    foreach (var socialData in socCont.getSocials())
                    {
                        locationSocials[socialData.getName()] = socialData.getAccount();

                    }
                    string locName = data.getName();
                    string locadd1 = data.getAdd1();
                    string locadd2 = data.getAdd2();
                    string locCity = data.getCity();
                    string locPost = data.getPost();
                    string locPho = data.getPhoneNum();
                    string locWeb = data.getWebsite();

                    locationData["location_name"] = locName;
                    locationData["location_address_1"] = locadd1;
                    locationData["location_address_2"] = locadd2;
                    locationData["location_city"] = locCity;
                    locationData["location_postcode"] = locPost;
                    locationData["location_phone"] = locPho;
                    locationData["location_website"] = locWeb;
                    locationData["location_socials"] = locationSocials;

                    // Serialize the inner dictionary to JSON and add it to the outer dictionary
                    locationsData["locationNum" + z] = locationData;
                    

                    
                    z++;
                }

                string json = JsonConvert.SerializeObject(locationsData);

                importedData.Rows[currentRow]["Locations"] = json;
                //Console.WriteLine(json);
            }


        }

        public void clearEntries()
        {
            //we wana save data first
            saveEntries();

            //now we clear it
            WebsiteInput.Text = "";
            NumNewStoresInput.Value = 0;
            NumDevStoresInput.Value = 0;
            BrandsInput.Text = "";
            LocationNameInput.Text = "";
            LocationWebsiteInput.Text = "";
            LocationPhoneNumberInput.Text = "";
            LocationAdd1Input.Text = "";
            LocationAdd2Input.Text = "";
            LocationCityInput.Text = "";
            LocationPostcodeInput.Text = "";
            SocialNameInput.Text = "";
            SocialTagInput.Text = "";

            //clear the locations, socials and brands now
            locController.Clear();
            brandController.Clear();
            currentSocController.Clear();
        }

        //stuff to controll the rows and stuff
        #region rowsController

        private void SelectButton_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(RowChooserDropDown.SelectedItem);

            //we clear all data first
            clearEntries();

            SetData(importedData.Rows[row]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            //we clear all data first
            clearEntries();

            currentRow--;
            if (currentRow <= -1)
            {
                currentRow = maxRow;
            }

            SetData(importedData.Rows[currentRow]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //we clear all data first
            clearEntries();

            currentRow++;
            if (currentRow > maxRow-1)
            {
                currentRow = 0;
            }

            SetData(importedData.Rows[currentRow]);
        }

        private void viewSocialsButton_Click(object sender, EventArgs e)
        {
            //we get the location, so we can display hte socials for it
            Button button = (Button)sender;
            Location tag = button.Tag as Location;

            //we return if we are teh same thing
            if (currentSocController == tag.getSocials())
            {
                //Console.WriteLine("returning");
                return;
            }

            //if this isnt null ,means theres prob stuff there, so lets see and delete it if there is
            if (currentSocController != null)
            {
               
                if (currentSocController.getSocials().Count > 0) // only if we have more
                {
                    currentSocController.Clear();
                }

            }

            //Console.WriteLine("spawning in new ones");
            //we now spawn in the next social data
            currentSocController = tag.getSocials();//get the socials
            foreach (Social socialData in currentSocController.getSocials())
            {
                //Console.WriteLine("spawning");
                socialData.CreateUI();
            }


        }
        private void SaveRowButton_Click(object sender, EventArgs e)
        {
            saveEntries();
        }

        #endregion

        #region Inputs



        private void BrandsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter key was pressed

                //get the brand
                string enteredValue = BrandsInput.Text;
                
                //put it in the controller
                Brand brand = new Brand(brandController.getBrands().Count-1, enteredValue, brandController, brandsContainer);

                brandController.AddEntry(brand);

                //we empty hte text field
                BrandsInput.Text = "";
            }
        }


        private void AddSocialsButton_Click(object sender, EventArgs e)
        {
            string socName = SocialNameInput.Text;
            string socTag = SocialTagInput.Text;

            if(socName != string.Empty && socTag != string.Empty)
            {

            }

        }
        #endregion


    }
}
