using HospitalityDataUpdater._cs.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalityDataUpdater._cs
{
    internal class Brand
    {
        //controller
        BrandController controller;
        //vars
        int index;
        string Name;
        //UI Vars
        GroupBox groupBox = new GroupBox();
        Button deleteButton = new Button();
        FlowLayoutPanel container;

        //Constructor
        public Brand(int i, string name, BrandController cont, FlowLayoutPanel container)
        {
            index = i;
            SetName(name);
            SetContainer(container);
            SetController(cont);
            CreateUI();
        }

        //get Methods
        //Simple methods to get all the variables within this class
        #region getMethods
        public string GetName()
        {
            return Name;
        }
        public BrandController GetController()
        {
            return controller;
        }
        #endregion
        //set Methods
        //Simple methods to set all the variables within this class
        #region setMethods
        public void SetName(string n)
        {
            Name = n;
        }
        public void SetContainer(FlowLayoutPanel c)
        {
            container = c;
        }
        public void SetController(BrandController cont)
        {
            controller = cont;
        }
        #endregion



        //ui Methods
        #region uiMethods
        public void ClearUI()// Method Used to clear the UI
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
        public void DeleteButton_Pressed()// Method used to delete the UI when the button is pressed
        {// Handle the button click event
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
        public void CreateUI() //creates the UI
        {
            groupBox = new GroupBox();
            deleteButton = new Button();

            // 
            // Brand
            // 
            this.groupBox.Controls.Add(this.deleteButton);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "BrandGroupBox"+index;
            this.groupBox.Size = new System.Drawing.Size(68, 33);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = GetName();
            // 
            // Deletebrand1
            // 
            this.deleteButton.Location = new System.Drawing.Point(1, 10);
            this.deleteButton.Name = "DeleteBrand"+index;
            this.deleteButton.Size = new System.Drawing.Size(61, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;

            // Define the event handler for the button click event
            EventHandler deleteButtonClickHandler = (sender, e) =>
            {
                DeleteButton_Pressed();
            };
            // Subscribe to the button's Click event using the event handler
            deleteButton.Click += deleteButtonClickHandler;
            //
            // Assigns the new ui to the container. displaying it
            //
            container.Controls.Add(groupBox);
        }

        #endregion

    }
}
