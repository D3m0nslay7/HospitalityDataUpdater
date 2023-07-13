using HospitalityDataUpdater._cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
using UserControl = System.Windows.Forms.UserControl;

namespace HospitalityDataUpdater.Windows
{
    partial class EditControl : UserControl
    {
        private Location data;

        public EditControl(Location inputData)
        {
            InitializeComponent();
            data = inputData;

            Edit_LocationIdLabel.Text = Edit_LocationIdLabel.Text + data.getIndex();
        }

        private void EditControl_Load(object sender, EventArgs e)
        {
            //we want to set the fields to the data we have
            SetFields();
        }

        #region Methods

        private void SetFields() //set the ui textbox fields
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

            //get the socials
            //Edit_SocialNameInput.Text = data.get;
            Edit_SocialTagInput.Text = "";

        }


        #endregion

        private void Edit_SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void Edit_CancelButton_Click(object sender, EventArgs e)
        {
            // Get the parent container and remove the user control
            Control parentContainer = this.Parent;
            if (parentContainer != null)
            {
                parentContainer.Controls.Remove(this);
                this.Dispose(); // Optional: Dispose of the user control if necessary

                
            }
        }
    }
}
