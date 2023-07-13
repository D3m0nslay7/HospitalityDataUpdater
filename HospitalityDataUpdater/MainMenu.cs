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
using OfficeOpenXml;
using System.IO;
using Newtonsoft.Json.Linq;
using PhoneNumbers;
using HospitalityDataUpdater.Windows;
using System.Windows.Controls;
using Button = System.Windows.Forms.Button;
using System.Collections;
using static OfficeOpenXml.ExcelErrorValue;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace HospitalityDataUpdater
{
    public partial class MainMenuInterface : Form
    {
        //data
        DataTable importedData;
        int currentRowNum;
        int maxRow;
        //containers
        FlowLayoutPanel locationsContainer;
        FlowLayoutPanel locationSocialsContainer;
        FlowLayoutPanel brandsContainer;
        FlowLayoutPanel companySocialsContainer;
        //controllers
        LocationController locationController;
        SocialController locationSocialController;
        BrandController brandController;
        SocialController companySocialController;
        //used to check if we have any type of popup open
        bool popup = false;

        string filePath = @"C:\ExcelData\";

        public MainMenuInterface()
        {
            InitializeComponent();
            FileNameTextbox.Text = "File Name Here";
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //setup
            #region setup

            //here we get the containers for the UI
            locationsContainer = this.Controls.Find("LocationFlowLayout", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            locationSocialsContainer = this.Controls.Find("SocialsLayoutContainer", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            brandsContainer = this.Controls.Find("BrandsFlowLayout", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container
            companySocialsContainer = this.Controls.Find("CompanySocialsFlowLayout", true).FirstOrDefault() as FlowLayoutPanel; // we get the socials container

            companySocialController = null;
            #endregion
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


            #region excel


            #endregion
            //makes the filepath
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
                Console.WriteLine("Folder created successfully.");
            }
            else
            {
                Console.WriteLine("Folder already exists.");
            }
        }







        #region UI Methods

        private void ViewSocialsButton_Click(object sender, EventArgs e)
        {
            //we get the location, so we can display hte socials for it
            Button button = (Button)sender;
            Location tag = button.Tag as Location;

            //we return if we are teh same thing
            if (locationSocialController == tag.getSocialController())
            {
                //Console.WriteLine("returning");
                return;
            }

            //if this isnt null ,means theres prob stuff there, so lets see and delete it if there is
            if (locationSocialController != null)
            {

                if (locationSocialController.getSocials().Count > 0) // only if we have more
                {
                    locationSocialController.Clear();
                }

            }

            //Console.WriteLine("spawning in new ones");
            //we now spawn in the next social data
            locationSocialController = tag.getSocialController();//get the socials
            if (locationSocialController != null)
            {
                foreach (Social socialData in locationSocialController.getSocials())
                {
                    //Console.WriteLine("spawning");
                    socialData.CreateUI(locationSocialsContainer);
                }
            }
            


        }

        private void EmptyLocInputs()
        {
            LocationNameInput.Text = "";
            LocationWebsiteInput.Text = "";
            LocationPhoneNumberInput.Text = "";
            LocationAdd1Input.Text = "";
            LocationAdd2Input.Text = "";
            LocationCityInput.Text = "";
            LocationPostcodeInput.Text = "";
            SocialNameInput.Text = "";
            SocialTagInput.Text = "";
            LocationBookingProviderInput.Text = "";
        }



        #endregion

        #region Edit Panel
        private void UserControl_Disposed(object sender, EventArgs e)
        {
            popup = false;

            Console.WriteLine();

            //check if we have imported data
            if (importedData != null)
            {
                //save the data in a backup excel file for saftey
                exportFile("backup");

                SetData(importedData.Rows[currentRowNum]);
            }


        }

        private void EditDataButton_Click(object sender, EventArgs e) // simple function to launch edit panel and allow the user to edit this location
        {
            //checks if we already have a popup open
            if (popup)
            {
                MessageBox.Show("INFO: Finish editing the current location first");
                return;
            }

            //get the location, if we dont have one we return and let the person know
            Button button = (Button)sender;
            if (button.Tag == null)
            {
                MessageBox.Show("WARNING: did not send a location class to edit, so returned");
                return;
            }

            Location location = button.Tag as Location;

            if (locationSocialController != null)
                locationSocialController.Clear();

            //we create the edit panel and show it
            EditControl panel = new EditControl(location, ViewSocialsButton_Click, EditDataButton_Click);
            panel.Location = new System.Drawing.Point(0, -7);
            LocationsGroupBox.Controls.Add(panel);
            panel.BringToFront();
            //an event handler to tell us if hte user gets disposed
            panel.Disposed += UserControl_Disposed;

            popup = true;



        }
        #endregion

        #region excel

        private void exportFile(string param)
        {
            if(importedData == null)
            {
                return;
            }
            clearEntries();
            string newFilePath = "";
            if(FileSaveNameInput.Text == string.Empty)
            {
                newFilePath = filePath+FileNameTextbox.Text + ".xlsx";
            }
            else
            {
                newFilePath = filePath+FileSaveNameInput.Text + ".xlsx";
            }

            //here we check the paramter if its meant to be a backup
            if (param == "backup")
            {
                newFilePath = filePath + "backup.xlsx";
            }
           
            var excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

            // Write column headers to the worksheet
            for (int columnIndex = 0; columnIndex < importedData.Columns.Count; columnIndex++)
            {
                worksheet.Cells[1, columnIndex + 1].Value = importedData.Columns[columnIndex].ColumnName;
            }

            // Write data rows to the worksheet
            for (int rowIndex = 0; rowIndex < importedData.Rows.Count; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < importedData.Columns.Count; columnIndex++)
                {
                    worksheet.Cells[rowIndex + 2, columnIndex + 1].Value = importedData.Rows[rowIndex][columnIndex];
                }
            }

            //trys to save the file, if it cant, it throws us an error
            try
            {
                excelPackage.SaveAs(new System.IO.FileInfo(newFilePath));
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            //we dont want to display the saved message if its from an autosave type feature, could be annoying for end user
            if (param != "next" && param != "prev" && param != "sele" && param != "backup")
            {
                MessageBox.Show("Successfully saved data to: " + FileSaveNameInput.Text);
            }
            
        }
        private DataTable Import(int startRow, int endRow) // used to import the data we want
        {
            if (importedData != null)
            {
                clearEntries();
            }

            string path = filePath+FileNameTextbox.Text + ".xlsx"; // get the filepath from the ui
            if (File.Exists(path))
            {
                try
                {
                    using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
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

                            if (locationSocialController != null)
                            {
                                locationSocialController.Clear();
                            }

                            locationSocialController = null;
                            return filteredTable;
                        }
                    }
                }
                catch  (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }  
            }
            else
            {
                MessageBox.Show("Failed to import, file doesnt exist");
                return null;
            }
           
        }
        private int GetExcelRowCount(string filePath) // used to retrieve the amount of rows
        {
            if (File.Exists(filePath))
            {
                try
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
                catch (IOException)
                {
                    MessageBox.Show("File is already open or in use by another process.");
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Warning, file does not exist!");
                return -1;
            }
            
        }
        #endregion

        #region Methods

        private void SetData(DataRow row)//set the data, when we get the data
        {
            //we import the data now

            //get new controllers, we dont want any old data
            //here we get the controlelrs
            locationController = new LocationController(locationsContainer, ViewSocialsButton_Click, EditDataButton_Click);
            locationSocialController = new SocialController();
            brandController = new BrandController();

            //company name
            CompanyNameLabel.Text = "Company Name: " + row["Company"].ToString();
            //website
            WebsiteInput.Text = row["Website"].ToString();
            //new stores
            if (row["New_Num_Stores"].ToString() == string.Empty)
            {
                NumNewStoresInput.Value = Convert.ToInt32(row["Number of Sites"].ToString()); ;
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

            if (row["Inactive"].ToString() == string.Empty)
            {
                InactiveCheckbox.Checked = false;
            }
            else
            {
                InactiveCheckbox.Checked = Convert.ToBoolean(row["Inactive"]);
            }


            if (row["Brands"] != null)
            {

                //brands
                string brandsJson = row["Brands"].ToString();
                string[] brands = JsonConvert.DeserializeObject<string[]>(brandsJson);
                if (brands != null)
                {
                    for (int i = 0; i < brands.Length; i++)
                    {
                        Brand brand = new Brand(i, brands[i], brandController, brandsContainer);

                        brandController.AddEntry(brand);
                    }
                }
            }



            if (!row.IsNull("Company_Socials"))
            {
                try
                {
                    //we get the company socials, and turn them into a dictionary
                    Dictionary<string, List<string>> companySocials = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(row["Company_Socials"].ToString());

                    //we create a company social controller
                    companySocialController = new SocialController();
                    //check if its null
                    if (companySocials != null)
                    {
                        int p = 0;
                        foreach (var social in companySocials)
                        {
                            foreach (string item in social.Value)
                            {

                                Social soc = new Social(p, social.Key, item, companySocialController);

                                companySocialController.AddEntry(soc);
                                p++;
                            }
                        }
                    }

                    //now we display the company socials
                    foreach (Social social in companySocialController.getSocials())
                    {
                        social.CreateUI(companySocialsContainer);
                    }

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("Bit of an error with company socials buddy");
                }
                
            }
            else
            {
                MessageBox.Show("WARNING: please contact the developer, you are you using an outdated excel file");
            }

            //Console.WriteLine(row["New_Num_Stores"].ToString());



            //locations in a dictionary
            if (!row.IsNull("Locations"))
            {
                try
                {
                    var locations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(row["Locations"].ToString());
                    //loop through each location, and create one and put it in locationscontainer

                    if (locations != null)
                    {
                        int z = 0;
                        foreach (var data in locations)
                        {

                            string key = data.Key; // Get the outer dictionary key
                            Dictionary<string, object> innerDict = data.Value; // Get the inner dictionary data
                            //first we setup the socials
                            SocialController socCont = new SocialController();

                            // Access the "location_socials" inner object
                            if (innerDict["location_socials"] != null)
                            {
                                //JObject locationSocialsObject = (JObject)innerDict["location_socials"];
                                // we are going to try import the data using the new format,
                                try
                                {
                                    Dictionary<string, List<string>> locationSocials = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(innerDict["location_socials"].ToString());

                                    //check if its null
                                    if (locationSocials != null)
                                    {
                                        int p = 0;
                                        foreach (var social in locationSocials)
                                        {
                                            foreach (string item in social.Value)
                                            {

                                                Social soc = new Social(p, social.Key, item, socCont);

                                                socCont.AddEntry(soc);
                                                p++;
                                            }
                                        }
                                    }
                                }
                                //there was an error importing
                                catch (Exception)
                                {
                                    //we will now try importing based on the old format
                                    //the reason this works is because we save it as the new format, meaning old data can now be saved as such
                                    MessageBox.Show("You are using an old location, we are going to reformat it normally");
                                    try
                                    {
                                        Dictionary<string, object>  locationSocials = JsonConvert.DeserializeObject<Dictionary<string, object>>(innerDict["location_socials"].ToString());
                                        int p = 0;
                                        foreach (var item in locationSocials)
                                        {
                                            Social soc = new Social(p, item.Key, item.Value.ToString(), socCont);

                                            socCont.AddEntry(soc);
                                            p++;
                                        }

                                    }
                                    catch (Exception)
                                    {

                                        MessageBox.Show("You are using an old location, we are going to reformat it");
                                    }
                                    
                                }

                            }

                            string locName = null;
                            string locadd1 = null;
                            string locadd2 = null;
                            string locCity = null;
                            string locPost = null;
                            string locPho = null;
                            string locWeb = null;
                            string locBooking = null;
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
                                //Console.WriteLine(innerDict["location_phone"]);

                                JArray locationPhoneArray = (JArray)innerDict["location_phone"];
                                locPho = string.Join(" ", locationPhoneArray.Select(x => x.ToString()));
                                //Console.WriteLine(locPho);

                            }
                            if (innerDict["location_website"] != null)
                            {
                                locWeb = innerDict["location_website"].ToString();
                            }

                            //we want to check if this key exists, because it was added in later
                            if (innerDict.ContainsKey("booking_provider"))
                            {
                                if (innerDict["booking_provider"] != null)
                                {
                                    locBooking = innerDict["booking_provider"].ToString();
                                }
                            }
                            else
                            {
                                innerDict.Add("booking_provider", locBooking);
                            }



                            // now we import the locations
                            Location loc = new Location(z, locName, locWeb, locPho, locadd1, locadd2, locCity, locPost, locBooking, socCont, locationController, locationController.getLocationHolder()); // Create a new Location instance for each array element

                            locationController.AddEntry(loc);


                            z++;
                        }

                        //spawn the uis now

                        locationController.CreateLocationUIs();
                    }
                }
                catch (Exception test)
                {
                    Console.WriteLine(test.Message);
                    MessageBox.Show("Bit of an error with locations buddy");

                }

            }
        }

        private void saveEntries()
        {
            if(importedData != null)
            {
                //we save all the entries into the row
                importedData.Rows[currentRowNum]["Website"] = WebsiteInput.Text;
                importedData.Rows[currentRowNum]["New_Num_Stores"] = NumNewStoresInput.Value;
                importedData.Rows[currentRowNum]["Num_Developing_Stores"] = NumDevStoresInput.Value;
                importedData.Rows[currentRowNum]["Brands"] = brandController.getSaveableData();
                importedData.Rows[currentRowNum]["Inactive"] = InactiveCheckbox.Checked;

                //Company Locations in a dictionary
                Dictionary<string, List<string>> companySocials = new Dictionary<string, List<string>>();
                if (companySocialController != null)
                {
                    //check if we have any company socials to loop through
                    if (companySocialController.getSocials().Count > 0)
                    {

                        //we loop through company socials
                        foreach (Social social in companySocialController.getSocials())
                        {
                            //we check, if theres already an account, as in facebook, we just link the account we entered within the same field, 
                            if (companySocials.ContainsKey(social.getName()))
                            {
                                //here we'll check if we have the same name saved before
                                if (!companySocials[social.getName()].Contains(social.getTag()))
                                {
                                    companySocials[social.getName()].Add(social.getTag());
                                }
                                
                            }
                            else
                            {
                                //if not, we create a new list for it
                                companySocials[social.getName()] = new List<string> { social.getTag() };
                            }

                        }
                    }
                }
                
                string companySocialsJson = JsonConvert.SerializeObject(companySocials);
                importedData.Rows[currentRowNum]["Company_Socials"] = companySocialsJson;
                //locations in a dictionary
                Dictionary<string, object> locationsData = new Dictionary<string, object>();

                //loop through each location, and create one and put it in locationscontainer
                if (locationController.getLocations().Count > 0)
                {
                    int z = 1;
                    
                    foreach (Location data in locationController.getLocations())
                    {

                        Dictionary<string, object> locationData = new Dictionary<string, object>();

                        //first we setup the socials
                        SocialController socCont = data.getSocialController();
                        Dictionary<string, List<string>> locationSocials = new Dictionary<string, List<string>>();

                        if (socCont != null)
                        {
                            //check if we have any company socials to loop through
                            if (socCont.getSocials().Count > 0)
                            {

                                //we loop through company socials
                                foreach (Social social in socCont.getSocials())
                                {
                                    //we check, if theres already an account, as in facebook, we just link the account we entered within the same field, 
                                    if (locationSocials.ContainsKey(social.getName()))
                                    {
                                        //here we'll check if we have the same name saved before
                                        if (!locationSocials[social.getName()].Contains(social.getTag()))
                                        {
                                            locationSocials[social.getName()].Add(social.getTag());
                                        }

                                    }
                                    else
                                    {
                                        //if not, we create a new list for it
                                        locationSocials[social.getName()] = new List<string> { social.getTag() };
                                    }

                                }
                            }
                        }
                        string locName = data.getName();
                        string locadd1 = data.getAdd1();
                        string locadd2 = data.getAdd2();
                        string locCity = data.getCity();
                        string locPost = data.getPost();
                        string locPho = data.getPhoneNum();
                        string locWeb = data.getWebsite();
                        string locBooking = data.getBookingProvider();

                        string[] phoneNumbers = FormatPhoneNumber(locPho);
                        //Console.WriteLine(phoneNumbers);
                        JArray phojsonArray = null;
                        if (phoneNumbers != null)
                        {
                            phojsonArray = JArray.FromObject(phoneNumbers);
                        }


                        //string phoJson = phojsonArray.ToString();
                        //Console.WriteLine(phoJson);
                        locationData["location_name"] = locName;
                        locationData["location_address_1"] = locadd1;
                        locationData["location_address_2"] = locadd2;
                        locationData["location_city"] = locCity;
                        locationData["location_postcode"] = locPost;
                        locationData["location_phone"] = phojsonArray;
                        locationData["location_website"] = locWeb;
                        locationData["location_socials"] = locationSocials;
                        locationData["booking_provider"] = locBooking;

                        // Serialize the inner dictionary to JSON and add it to the outer dictionary
                        locationsData["Location: " + z] = locationData;



                        z++;
                    }

                   
                    //Console.WriteLine(json);
                }
                string locationsJsonDictionary = JsonConvert.SerializeObject(locationsData);

                importedData.Rows[currentRowNum]["Locations"] = locationsJsonDictionary;

            }

        }

        private void clearEntries()
        {

            //we wana save data first
            saveEntries();

            //now we clear it
            WebsiteInput.Text = "";
            NumNewStoresInput.Value = 0;
            NumDevStoresInput.Value = 0;
            BrandsInput.Text = "";
            InactiveCheckbox.Checked = false;

            EmptyLocInputs();


            //clear the locations, socials and brands now
            if (locationController != null)
                locationController.Clear();
            if (brandController != null)
                brandController.Clear();
            if (locationSocialController != null)
                locationSocialController.Clear();
            if(companySocialController != null)
                companySocialController.Clear();

        }

        private string[] FormatPhoneNumber(string phoneNumber)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
            string defaultRegion = "GB";
            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(phoneNumber, defaultRegion);

                // Extract calling code
                int callingCode = number.CountryCode;

                // Extract dialing code
                string dialingCode = phoneNumberUtil.GetNationalSignificantNumber(number);

                //Console.WriteLine("Calling Code: +" + callingCode);
                //Console.WriteLine("Dialing Code: " + dialingCode);
                int areaCodeNumber = phoneNumberUtil.GetLengthOfGeographicalAreaCode(number);


                string substring1 = dialingCode.Substring(0, areaCodeNumber);
                string substring2 = dialingCode.Substring(areaCodeNumber);
                string[] numberArray = new string[] { substring1, substring2 };
                //Console.WriteLine(areaCodeNumber);
                //Console.WriteLine(substring1 + "\\n" + substring2);
                return numberArray;
            }
            catch (NumberParseException ex)
            {
                Console.WriteLine("Invalid phone number: " + ex.Message);
                return null;
            }

        }

        #endregion

        //stuff to controll the rows and stuff
        #region rowsController

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (importedData == null) return;
            int row = Convert.ToInt32(RowChooserDropDown.SelectedItem);

            //we clear all data first
            saveEntries();
            exportFile("sele");
            currentRowNum = row;
            RowNumberLabel.Text = "Row Number: " + currentRowNum;
            SetData(importedData.Rows[row]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (importedData == null) return;


            exportFile("save");

            SetData(importedData.Rows[currentRowNum]);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (importedData == null) return;

            exportFile("prev");


            currentRowNum--;
            if (currentRowNum <= -1)
            {
                currentRowNum = maxRow-1;
            }

            RowNumberLabel.Text = "Row Number: " + currentRowNum;
            //set the data for the previous row
            SetData(importedData.Rows[currentRowNum]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (importedData == null) return;
            
            exportFile("next");

            currentRowNum++;
            if (currentRowNum > maxRow-1)
            {
                currentRowNum = 0;
            }

            RowNumberLabel.Text = "Row Number: " + currentRowNum;
            //set the data for the next row to view
            SetData(importedData.Rows[currentRowNum]);
        }
     
        private void SaveRowButton_Click(object sender, EventArgs e)
        {
            saveEntries();
        }

        #endregion

        //inputs into the interface.
        #region Inputs

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
            if (importedData != null)
            {
                RowChooserDropDown.Items.Clear();
                for (int i = 0; i < importedData.Rows.Count; i++)
                {
                    RowChooserDropDown.Items.Add(i);
                }
                currentRowNum = 0;
                RowNumberLabel.Text = "Row Number: " + currentRowNum;
                maxRow = importedData.Rows.Count;
                SetData(importedData.Rows[currentRowNum]);
                MessageBox.Show("Successfully inserted data");
            }

        }

        private void BrandsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter key was pressed

                //get the brand
                string enteredValue = BrandsInput.Text;
                
                //if brandcontroller is null, we make a new one
                if(brandController == null)
                {
                    brandController = new BrandController();
                }


                //Create brand item, then put it in controller
                Brand brand = new Brand(brandController.getBrands().Count-1, enteredValue, brandController, brandsContainer);
                brandController.AddEntry(brand);

                //we empty the text field
                BrandsInput.Text = "";
            }
        }

        private void AddSocialsButton_Click(object sender, EventArgs e)
        {
            //we get the values
            string socName = SocialNameInput.Text;
            string socTag = SocialTagInput.Text;
            Social socialItem;

            //first we check if there is a current social controller
            if (locationSocialController == null)
            {
                locationSocialController = new SocialController();
            }

            if (socName != string.Empty && socTag != string.Empty)
            {
                //we create the social item
                socialItem = new Social(locationSocialController.getSocials().Count, socName, socTag, locationSocialController);
                //add it to the social controller
                locationSocialController.AddEntry(socialItem);

                socialItem.CreateUI(locationSocialsContainer);
            }

        }

        private void CreateLocationButton_Click(object sender, EventArgs e)
        {
            #region input
            //get the values
            string locName = LocationNameInput.Text;
            string locWeb = LocationWebsiteInput.Text;
            string locPho = LocationPhoneNumberInput.Text;
            string locAdd1 = LocationAdd1Input.Text;
            string locAdd2 = LocationAdd2Input.Text;
            string locCity = LocationCityInput.Text;
            string locPost = LocationPostcodeInput.Text;
            string bookingProvider = LocationBookingProviderInput.Text;
            //check if anything is empty, so we can assign it a null value
            if (locName == string.Empty)
            {
                locName = null;
            }
            if (locWeb == string.Empty)
            {
                locWeb = null;
            }
            if (locPho == string.Empty)
            {
                locPho = null;
            }
            if (locAdd1 == string.Empty)
            {
                locAdd1 = null;
            }
            if (locAdd2 == string.Empty)
            {
                locAdd2 = null;
            }
            if (locCity == string.Empty)
            {
                locCity = null;
            }
            if (locPost == string.Empty)
            {
                locPost = null;
            }
            else
            {
                //we want to format the postcode
                //we get the length of the string, then split it based on the last 3 letters, to format the postcode
                int length = locPost.Length;
                string lastThreeLetters = locPost.Substring(length - 3);
                string modifiedString = locPost.Substring(0, length - 3) + " " + lastThreeLetters;

                locPost = modifiedString;
            }
            if(bookingProvider == string.Empty)
            {
                bookingProvider = null;
            }

            //now we create the location controller

            if (locationController == null)
            {
                
                locationController = new LocationController(locationsContainer, ViewSocialsButton_Click, EditDataButton_Click);
            }

            //we check if this is the first entry

            // now we import the locations
            Location loc = new Location(locationController.getLocations().Count, locName, locWeb, locPho, locAdd1, locAdd2, locCity, locPost, bookingProvider, locationSocialController, locationController, locationController.getLocationHolder()); // Create a new Location instance for each array element

            locationController.AddEntry(loc);

            locationController.CreateLocationUIs();

            

            EmptyLocInputs();

            if (locationSocialController != null)
            {
                locationSocialController.Clear();

            }

            locationSocialController = null;

            #endregion


            #region savingFile
            //check if we have imported data
            if (importedData != null)
            {
                //save the data in a backup excel file for saftey
                exportFile("backup");

                SetData(importedData.Rows[currentRowNum]);
            }


            #endregion
        }

        private void FilePathTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter key was pressed

                string enteredValue = filePath + FileNameTextbox.Text + ".xlsx";
                int rows = GetExcelRowCount(enteredValue);
                if (rows > -1)
                {
                    FromRowDropDown.Items.Clear();
                    ToRowDropDown.Items.Clear();
                    for (int i = 0; i < rows; i++)
                    {
                        FromRowDropDown.Items.Add(i);
                        ToRowDropDown.Items.Add(i);

                    }

                    MessageBox.Show("Successfully got the rows for the file, choose what u want to insert");
                }
            }
        }

        private void AddCompanySocialButton_Click(object sender, EventArgs e)// this is for the companies social controller
        {
            //we get the values
            string socName = CompanySocialsNameInput.Text;
            string socTag = CompanySocialsTagInput.Text;
            Social socialItem;

            //first we check if there is a current social controller
            if (companySocialController == null)
            {
                companySocialController = new SocialController();
            }

            if (socName != string.Empty && socTag != string.Empty)
            {
                //we create the social item
                socialItem = new Social(companySocialController.getSocials().Count, socName, socTag, companySocialController);
                //add it to the social controller
                companySocialController.AddEntry(socialItem);

                socialItem.CreateUI(companySocialsContainer);
            }
        }

        #endregion


    }
}
