using HospitalityDataUpdater._cs.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalityDataUpdater._cs
{
    internal class Location
    {

        //controller
        LocationController controller;
        //vars
        int index;
        string lname;
        string lWebsite;
        string lPhoneNum;
        string lAdd1;
        string lAdd2;
        string lCity;
        string lPost;

        SocialController socCont;
        //UI vars
        GroupBox groupBox = new GroupBox();
        Label locationName = new Label();
        Label locationAddress = new Label();
        Label locationWebsite = new Label();
        Button deleteButton = new Button();
        Button viewSocialsButton = new Button();
        FlowLayoutPanel container;

        public Location(int i, string name, string web, string num, string add1, string add2, string city, string postcode, SocialController socCont, LocationController cont, FlowLayoutPanel flowcontainer, EventHandler viewSocials)
        {
            index = i;
            setName(name);
            setWebsite(web);
            setPhoneNum(num);
            setAdd1(add1);
            setAdd2(add2);
            setCity(city);
            setPost(postcode);
            setController(cont);
            setSocials(socCont);
            if (flowcontainer == null)
                Console.WriteLine("NULL HERE");

            setContainer(flowcontainer);
            CreateUI(viewSocials);
        }
        //get methods
        #region getMethods
        public SocialController getSocials()
        {
            return socCont;
        }
        public LocationController getController()
        {
            return controller;
        }
        public string getName()
        {
            return lname;
        }
        public string getWebsite()
        {
            return lWebsite;
        }
        public string getPhoneNum()
        {
            return lPhoneNum;
        }
        public string getAdd1()
        {
            return lAdd1;
        }
        public string getAdd2()
        {
            return lAdd2;
        }
        public string getCity()
        {
            return lCity;
        }
        public string getPost()
        {
            return lPost;
        }
        #endregion
        //set methods
        #region setMethods
        public void setSocials(SocialController socs)
        {
            socCont = socs;
        }
        public void setContainer(FlowLayoutPanel panel)
        {
            container = panel;
        }
        public void setController(LocationController cont)
        {
            controller = cont;
        }
        public void setName(string name)
        {
            lname = name;

        }

        public void setWebsite(string web)
        {
            lWebsite = web;

        }
        public void setPhoneNum(string num)
        {
            lPhoneNum = num;

        }
        public void setAdd1(string add1)
        {
            lAdd1 = add1;

        }
        public void setAdd2(string add2)
        {
            lAdd2 = add2;

        }
        public void setCity(string city)
        {
            lCity = city;
            
        }
        public void setPost(string postcode)
        {
            lPost = postcode;
        }
        #endregion
        public void Clearing()
        {
            //delete this thing
            // Remove or dispose of the child controls within the GroupBox
            foreach (Control control in groupBox.Controls)
            {
                groupBox.Controls.Remove(control);
                control.Dispose(); // Optional: Dispose of the control if needed
            }

            // Remove the GroupBox itself from the container
            container.Controls.Remove(groupBox);

            // Dispose of the GroupBox if needed
            groupBox.Dispose();

        }
        //UI methods
        #region UI Methods

        public void DeleteUI()
        {
            // Handle the button click event
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //delete this thing
                // Remove or dispose of the child controls within the GroupBox
                foreach (Control control in groupBox.Controls)
                {
                    groupBox.Controls.Remove(control);
                    control.Dispose(); // Optional: Dispose of the control if needed
                }

                // Remove the GroupBox itself from the container
                container.Controls.Remove(groupBox);

                // Dispose of the GroupBox if needed
                groupBox.Dispose();

                //Now we delete this entry from the list
                controller.RemoveEntry(this);
            }
        }
        public void CreateUI(EventHandler viewSocialsButton_Click) //creates the UI for this
        {
            groupBox = new GroupBox();
            locationName = new Label();
            locationAddress = new Label();
            locationWebsite = new Label();
            deleteButton = new Button();
            viewSocialsButton = new Button();

            // 
            // Location1Group
            // 
            this.groupBox.Controls.Add(locationWebsite);
            this.groupBox.Controls.Add(locationAddress);
            this.groupBox.Controls.Add(locationName);
            this.groupBox.Controls.Add(deleteButton);
            this.groupBox.Controls.Add(viewSocialsButton);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "Location"+ index + "GroupBox";
            this.groupBox.Size = new System.Drawing.Size(506, 96);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Location - " + index;
            // 
            // locationName
            // 
            this.locationName.AutoSize = true;
            this.locationName.Location = new System.Drawing.Point(6, 16);
            this.locationName.Name = "LocationName"+index;
            this.locationName.Size = new System.Drawing.Size(82, 13);
            this.locationName.TabIndex = 0;
            this.locationName.Text = "Location Name: " +getName();
            // 
            // locationAddress
            // 
            this.locationAddress.AutoSize = true;
            this.locationAddress.Location = new System.Drawing.Point(6, 74);
            this.locationAddress.Name = "LocationAdd" + index;
            this.locationAddress.Size = new System.Drawing.Size(92, 13);
            this.locationAddress.TabIndex = 2;
            this.locationAddress.Text = "Location Address: " + getAdd1();
            // 
            // locationWebsite
            // 
            this.locationWebsite.AutoSize = true;
            this.locationWebsite.Location = new System.Drawing.Point(6, 45);
            this.locationWebsite.Name = "LocationWebsite"+index+"Label";
            this.locationWebsite.Size = new System.Drawing.Size(93, 13);
            this.locationWebsite.TabIndex = 1;
            this.locationWebsite.Text = "Location Website: "+getWebsite();
            // 
            // DeleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(425, 69);
            this.deleteButton.Name = "DeleteLocation"+ index;
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Tag = new { type = "location", index = index };

            // adds function to the button
            // Define the event handler for the button click event
            EventHandler deleteButtonClickHandler = (sender, e) =>
            {

                DeleteUI();
            };
            // Subscribe to the button's Click event using the event handler
            deleteButton.Click += deleteButtonClickHandler;
            // 
            // LocationSocialsButton1
            // 
            this.viewSocialsButton.Location = new System.Drawing.Point(425, 11);
            this.viewSocialsButton.Name = "LocationSocialsButton"+index;
            this.viewSocialsButton.Size = new System.Drawing.Size(75, 23);
            this.viewSocialsButton.TabIndex = 27;
            this.viewSocialsButton.Text = "View Socials";
            this.viewSocialsButton.Tag = this;
            this.viewSocialsButton.UseVisualStyleBackColor = true;

            // Subscribe to the button's Click event using the event handler
            this.viewSocialsButton.Click += new System.EventHandler(viewSocialsButton_Click);

            //
            // Assigns the new ui to the container. displaying it
            //

            container.Controls.Add(groupBox);
            //Console.WriteLine("Printed stufff");
        }
        public void RefreshUI() //refresh's the UI for this
        {
            //we dont need this atm
        }

        #endregion
    }
}
