using HospitalityDataUpdater._cs;
using HospitalityDataUpdater._cs.Controllers;
using System;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
using UserControl = System.Windows.Forms.UserControl;

namespace HospitalityDataUpdater.Windows
{
    partial class EditControl : UserControl
    {
        Location data;
        SocialController currentSocialController = null;

        //the socials flow layout Panel
        FlowLayoutPanel socialsContainer;

        //methods relating to the mainmenu
        EventHandler viewSocials = null;
        EventHandler editLocation = null;
        public EditControl(Location inputData, EventHandler viewSoc, EventHandler editLoc)
        {
            InitializeComponent();
            data = inputData;

            viewSocials = viewSoc;
            editLocation = editLoc;

            Edit_LocationIdLabel.Text = Edit_LocationIdLabel.Text + data.getIndex();
            socialsContainer = Edit_SocialsLayoutContainer;
        }

        private void EditControl_Load(object sender, EventArgs e)
        {
            //we want to set the fields to the data we have
            SetFields();
        }

        #region Methods

        private void SetFields() //set the fields from this location class to edit
        {
            //get the normal fields
            Edit_LocationNameInput.Text = data.getName();
            Edit_LocationWebsiteInput.Text = data.getWebsite();
            Edit_LocationPhoneNumberInput.Text = data.getPhoneNum();
            Edit_LocationAdd1Input.Text = data.getAdd1();
            Edit_LocationAdd2Input.Text = data.getAdd2();
            Edit_LocationCityInput.Text = data.getCity();
            Edit_LocationPostcodeInput.Text = data.getPost();

            Edit_LocationBookingProviderInput.Text = data.getBookingProvider();

            //make sure we have the panel
            if (socialsContainer != null)
            {

                //we now spawn in the next social data
                currentSocialController = data.getSocialController();//get the socials
                if (currentSocialController != null) // check if we have socials
                {
                    foreach (Social socialData in currentSocialController.getSocials())
                    {
                        //Console.WriteLine("spawning");
                        socialData.CreateUI(socialsContainer);
                    }
                }
              
            }
        }

        private void ClosePanel()
        {
            // Get the parent container and remove the user control
            Control parentContainer = this.Parent;
            if (parentContainer != null)
            {
                parentContainer.Controls.Remove(this);
                this.Dispose(); // Optional: Dispose of the user control if necessary


            }
        }

        #endregion

        #region Buttons

        private void Edit_SaveButton_Click(object sender, EventArgs e) // save the data into the location class provided.
        {
            //get the values
            string locName = Edit_LocationNameInput.Text;
            string locWeb = Edit_LocationWebsiteInput.Text;
            string locPho = Edit_LocationPhoneNumberInput.Text;
            string locAdd1 = Edit_LocationAdd1Input.Text;
            string locAdd2 = Edit_LocationAdd2Input.Text;
            string locCity = Edit_LocationCityInput.Text;
            string locPost = Edit_LocationPostcodeInput.Text;
            string bookingProvider = Edit_LocationBookingProviderInput.Text;
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
            if (bookingProvider == string.Empty)
            {
                bookingProvider = null;
            }

            //now we get the location controller
            LocationController locController = data.getController();


            // now we import the locations
            Location loc = new Location(data.getIndex(), locName, locWeb, locPho, locAdd1, locAdd2, locCity, locPost, bookingProvider, currentSocialController, locController, locController.getLocationHolder()); // Create a new Location instance for each array element

            //replace the old location with the new one.
            locController.ReplaceEntry(data, loc);

            ClosePanel();

        }

        private void Edit_CancelButton_Click(object sender, EventArgs e) // leaves the edit panel
        {
            ClosePanel();
        }

        private void Edit_AddSocialsButton_Click(object sender, EventArgs e)
        {
            //we get the values
            string socName = Edit_SocialNameComboBox.SelectedItem.ToString();
            string socTag = Edit_SocialTagInput.Text;
            Social socialItem;

            //first we check if there is a current social controller
            if (currentSocialController == null)
            {
                currentSocialController = new SocialController();
            }

            if (socName != string.Empty && socTag != string.Empty) // check if any of the strings are empty, if the are we dont add it
            {
                //we create the social item
                socialItem = new Social(currentSocialController.getSocials().Count, socName, socTag, currentSocialController);
                //add it to the social controller
                currentSocialController.AddEntry(socialItem);

                socialItem.CreateUI(socialsContainer);
            }
        }
    }

    #endregion

}
