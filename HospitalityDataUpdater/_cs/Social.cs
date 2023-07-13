using HospitalityDataUpdater._cs.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalityDataUpdater._cs
{
    //class to hold social inputs
    internal class Social
    {
        //controller
        SocialController controller;
        //vars
        int index;
        string Name;
        string Account;
        //UI vars
        GroupBox groupBox;
        Button deleteButton;
        Label socialTag;
        FlowLayoutPanel container;

        //sets the values when this is created
        public Social(int i, string name, string account, SocialController cont)
        {
            index = i;
            setName(name);
            setAccount(account);
            setContainer(container);
            setController(cont);
            //create the ui now
            //CreateUI();
        }

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

        //Setting Methods
        #region setMethods
        public void setName(string n) // sets name of social media
        {
            Name = n;
        }
        public void setAccount(string a) // sets the account of the social media
        {
            Account = a;
        }
        public void setContainer(FlowLayoutPanel panel)
        {
            container = panel;
        }
        public void setController(SocialController cont)
        {
            controller = cont;
        }
        #endregion
        //get Methods
        #region getMethods
        public SocialController getController()
        {
            return controller;
        }
        public string getName()// gets the name information
        {
            return Name;
        }
        public string getAccount() // gets the account information
        {
            return Account;
        }
        #endregion
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
        public void CreateUI(FlowLayoutPanel container) {  //creates the UI 

            groupBox = new GroupBox();
            deleteButton = new Button();
            socialTag = new Label();

            setContainer(container);

            // 
            // Social1Group
            // 
            this.groupBox.Controls.Add(this.socialTag);
            this.groupBox.Controls.Add(this.deleteButton);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "SocialBox"+index;
            this.groupBox.Size = new System.Drawing.Size(241, 50);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = getName();
            // 
            // DeleteSocialButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(187, 7);
            this.deleteButton.Name = "SocialDelete"+index;
            this.deleteButton.Size = new System.Drawing.Size(48, 43);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Tag = new {type = "social", index = index};

            //adds function to the button
            // Define the event handler for the button click event
            EventHandler deleteButtonClickHandler = (sender, e) =>
            {
                DeleteUI();
            };
            // Subscribe to the button's Click event using the event handler
            deleteButton.Click += deleteButtonClickHandler;

            // 
            // SocialTag1Label
            // 
            this.socialTag.AutoSize = true;
            this.socialTag.Location = new System.Drawing.Point(7, 20);
            this.socialTag.Name = "TagSocial"+index;
            this.socialTag.Size = new System.Drawing.Size(35, 13);
            this.socialTag.TabIndex = 28;
            this.socialTag.Text = "Social Tag: " + getAccount();


            container.Controls.Add(groupBox);
        }
        public void RefreshUI() //refreshes the UI
        {

        }


        #endregion
    }
}
