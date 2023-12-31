﻿using System.Windows.Forms;

namespace HospitalityDataUpdater
{
    partial class MainMenuInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuInterface));
            this.LocationFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.InputPanel = new System.Windows.Forms.GroupBox();
            this.CompanySocialsGroupBox = new System.Windows.Forms.GroupBox();
            this.CompanySocialsNameComboBox = new System.Windows.Forms.ComboBox();
            this.SocialsHolderPanel = new System.Windows.Forms.Panel();
            this.CompanySocialsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CompanySocialsTagInput = new System.Windows.Forms.TextBox();
            this.AddCompanySocialButton = new System.Windows.Forms.Button();
            this.CompanySocialsNameLabel = new System.Windows.Forms.Label();
            this.CompanySocialsTagLabel = new System.Windows.Forms.Label();
            this.InactiveCheckbox = new System.Windows.Forms.CheckBox();
            this.NumDevStoresInput = new System.Windows.Forms.NumericUpDown();
            this.NumNewStoresInput = new System.Windows.Forms.NumericUpDown();
            this.BrandsGroupBox = new System.Windows.Forms.GroupBox();
            this.BrandsInputLabel = new System.Windows.Forms.Label();
            this.BrandsInput = new System.Windows.Forms.TextBox();
            this.BrandsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Num_Dev_StoresLabel = new System.Windows.Forms.Label();
            this.New_Num_StoresLabel = new System.Windows.Forms.Label();
            this.WebsiteInput = new System.Windows.Forms.TextBox();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.LocationsGroupBox = new System.Windows.Forms.GroupBox();
            this.SocialNameComboBox = new System.Windows.Forms.ComboBox();
            this.LocationBookingProviderInput = new System.Windows.Forms.TextBox();
            this.LocationBookingProviderLabel = new System.Windows.Forms.Label();
            this.LocationsPanel = new System.Windows.Forms.Panel();
            this.SocialTagInput = new System.Windows.Forms.TextBox();
            this.SocialsGroupBox = new System.Windows.Forms.GroupBox();
            this.SocialsLayoutContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SocialTagLabel = new System.Windows.Forms.Label();
            this.LocationAdd1Input = new System.Windows.Forms.TextBox();
            this.LocationAddress1Label = new System.Windows.Forms.Label();
            this.LocationPhoneNumberLabel = new System.Windows.Forms.Label();
            this.LocationAddress2Label = new System.Windows.Forms.Label();
            this.LocationPhoneNumberInput = new System.Windows.Forms.TextBox();
            this.LocationPostcodeInput = new System.Windows.Forms.TextBox();
            this.SocialNameLabel = new System.Windows.Forms.Label();
            this.LocationAdd2Input = new System.Windows.Forms.TextBox();
            this.LocationWebsiteInput = new System.Windows.Forms.TextBox();
            this.LocationCityLabel = new System.Windows.Forms.Label();
            this.LocationWebsiteLabel = new System.Windows.Forms.Label();
            this.LocationCityInput = new System.Windows.Forms.TextBox();
            this.LocationPostcodeLabel = new System.Windows.Forms.Label();
            this.AddSocialsButton = new System.Windows.Forms.Button();
            this.LocationNameInput = new System.Windows.Forms.TextBox();
            this.LocationNameLabel = new System.Windows.Forms.Label();
            this.CreateLocationButton = new System.Windows.Forms.Button();
            this.LocationsSavedLabel = new System.Windows.Forms.Label();
            this.ExcelPanel = new System.Windows.Forms.GroupBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ToRowDropDown = new System.Windows.Forms.ComboBox();
            this.RowToRow = new System.Windows.Forms.Label();
            this.FromRowDropDown = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExcelControls = new System.Windows.Forms.GroupBox();
            this.CurrRowsContr = new System.Windows.Forms.GroupBox();
            this.SaveFileLabel = new System.Windows.Forms.Label();
            this.FileSaveNameInput = new System.Windows.Forms.TextBox();
            this.SaveRowButton = new System.Windows.Forms.Button();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.RowChooserDropDown = new System.Windows.Forms.ComboBox();
            this.RowChooseLabel = new System.Windows.Forms.Label();
            this.RowNumberLabel = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.InputsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.InputPanel.SuspendLayout();
            this.CompanySocialsGroupBox.SuspendLayout();
            this.SocialsHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDevStoresInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNewStoresInput)).BeginInit();
            this.BrandsGroupBox.SuspendLayout();
            this.LocationsGroupBox.SuspendLayout();
            this.LocationsPanel.SuspendLayout();
            this.SocialsGroupBox.SuspendLayout();
            this.ExcelPanel.SuspendLayout();
            this.ExcelControls.SuspendLayout();
            this.CurrRowsContr.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationFlowLayout
            // 
            this.LocationFlowLayout.AutoScroll = true;
            this.LocationFlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.LocationFlowLayout.Name = "LocationFlowLayout";
            this.LocationFlowLayout.Size = new System.Drawing.Size(529, 413);
            this.LocationFlowLayout.TabIndex = 0;
            this.InputsToolTip.SetToolTip(this.LocationFlowLayout, "Locations Container:\r\nA container to hold created location items, locations can b" +
        "e edited or deleted here. You can also choose to view specific socials for locat" +
        "ions here as well.");
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.CompanySocialsGroupBox);
            this.InputPanel.Controls.Add(this.InactiveCheckbox);
            this.InputPanel.Controls.Add(this.NumDevStoresInput);
            this.InputPanel.Controls.Add(this.NumNewStoresInput);
            this.InputPanel.Controls.Add(this.BrandsGroupBox);
            this.InputPanel.Controls.Add(this.Num_Dev_StoresLabel);
            this.InputPanel.Controls.Add(this.New_Num_StoresLabel);
            this.InputPanel.Controls.Add(this.WebsiteInput);
            this.InputPanel.Controls.Add(this.WebsiteLabel);
            this.InputPanel.Location = new System.Drawing.Point(12, 169);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(376, 513);
            this.InputPanel.TabIndex = 0;
            this.InputPanel.TabStop = false;
            this.InputPanel.Text = "Input";
            // 
            // CompanySocialsGroupBox
            // 
            this.CompanySocialsGroupBox.Controls.Add(this.CompanySocialsNameComboBox);
            this.CompanySocialsGroupBox.Controls.Add(this.SocialsHolderPanel);
            this.CompanySocialsGroupBox.Controls.Add(this.CompanySocialsTagInput);
            this.CompanySocialsGroupBox.Controls.Add(this.AddCompanySocialButton);
            this.CompanySocialsGroupBox.Controls.Add(this.CompanySocialsNameLabel);
            this.CompanySocialsGroupBox.Controls.Add(this.CompanySocialsTagLabel);
            this.CompanySocialsGroupBox.Location = new System.Drawing.Point(4, 226);
            this.CompanySocialsGroupBox.Name = "CompanySocialsGroupBox";
            this.CompanySocialsGroupBox.Size = new System.Drawing.Size(366, 281);
            this.CompanySocialsGroupBox.TabIndex = 18;
            this.CompanySocialsGroupBox.TabStop = false;
            this.CompanySocialsGroupBox.Text = "Company Socials";
            // 
            // CompanySocialsNameComboBox
            // 
            this.CompanySocialsNameComboBox.DisplayMember = "10000";
            this.CompanySocialsNameComboBox.FormattingEnabled = true;
            this.CompanySocialsNameComboBox.Items.AddRange(new object[] {
            "youtube",
            "linkedin",
            "instagram",
            "twitter",
            "facebook",
            "tiktok",
            "snapchat",
            "pinterest"});
            this.CompanySocialsNameComboBox.Location = new System.Drawing.Point(79, 19);
            this.CompanySocialsNameComboBox.Name = "CompanySocialsNameComboBox";
            this.CompanySocialsNameComboBox.Size = new System.Drawing.Size(119, 21);
            this.CompanySocialsNameComboBox.TabIndex = 18;
            this.CompanySocialsNameComboBox.TabStop = false;
            this.CompanySocialsNameComboBox.Text = "Select Social Media";
            this.InputsToolTip.SetToolTip(this.CompanySocialsNameComboBox, "Social Name Dropdown:\r\nDropdown box containing Social Media names, this is to pro" +
        "vide consitency and remove human errors such as spelling mistakes.");
            // 
            // SocialsHolderPanel
            // 
            this.SocialsHolderPanel.Controls.Add(this.CompanySocialsFlowLayout);
            this.SocialsHolderPanel.Location = new System.Drawing.Point(6, 67);
            this.SocialsHolderPanel.Name = "SocialsHolderPanel";
            this.SocialsHolderPanel.Size = new System.Drawing.Size(354, 205);
            this.SocialsHolderPanel.TabIndex = 31;
            // 
            // CompanySocialsFlowLayout
            // 
            this.CompanySocialsFlowLayout.AutoScroll = true;
            this.CompanySocialsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanySocialsFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.CompanySocialsFlowLayout.Name = "CompanySocialsFlowLayout";
            this.CompanySocialsFlowLayout.Size = new System.Drawing.Size(354, 205);
            this.CompanySocialsFlowLayout.TabIndex = 3;
            this.InputsToolTip.SetToolTip(this.CompanySocialsFlowLayout, "Company Socials Container:\r\nSimple container for social media items created for t" +
        "his companies socials.");
            // 
            // CompanySocialsTagInput
            // 
            this.CompanySocialsTagInput.Location = new System.Drawing.Point(72, 41);
            this.CompanySocialsTagInput.Name = "CompanySocialsTagInput";
            this.CompanySocialsTagInput.Size = new System.Drawing.Size(126, 20);
            this.CompanySocialsTagInput.TabIndex = 19;
            this.InputsToolTip.SetToolTip(this.CompanySocialsTagInput, "Social Media Tag:\r\nThe social media tag, has to be correct.\r\nNOTE: Should not con" +
        "tain the @ Symbol");
            // 
            // AddCompanySocialButton
            // 
            this.AddCompanySocialButton.Location = new System.Drawing.Point(204, 19);
            this.AddCompanySocialButton.Name = "AddCompanySocialButton";
            this.AddCompanySocialButton.Size = new System.Drawing.Size(154, 42);
            this.AddCompanySocialButton.TabIndex = 20;
            this.AddCompanySocialButton.Text = "Add Social";
            this.InputsToolTip.SetToolTip(this.AddCompanySocialButton, "Add Social Button:\r\nWill create a social media item based on the inputs, the item" +
        " can be deleted if required.");
            this.AddCompanySocialButton.UseVisualStyleBackColor = true;
            this.AddCompanySocialButton.Click += new System.EventHandler(this.AddCompanySocialButton_Click);
            // 
            // CompanySocialsNameLabel
            // 
            this.CompanySocialsNameLabel.AutoSize = true;
            this.CompanySocialsNameLabel.Location = new System.Drawing.Point(5, 22);
            this.CompanySocialsNameLabel.Name = "CompanySocialsNameLabel";
            this.CompanySocialsNameLabel.Size = new System.Drawing.Size(70, 13);
            this.CompanySocialsNameLabel.TabIndex = 27;
            this.CompanySocialsNameLabel.Text = "Social Name:";
            // 
            // CompanySocialsTagLabel
            // 
            this.CompanySocialsTagLabel.AutoSize = true;
            this.CompanySocialsTagLabel.Location = new System.Drawing.Point(5, 44);
            this.CompanySocialsTagLabel.Name = "CompanySocialsTagLabel";
            this.CompanySocialsTagLabel.Size = new System.Drawing.Size(61, 13);
            this.CompanySocialsTagLabel.TabIndex = 26;
            this.CompanySocialsTagLabel.Text = "Social Tag:";
            // 
            // InactiveCheckbox
            // 
            this.InactiveCheckbox.AutoSize = true;
            this.InactiveCheckbox.Location = new System.Drawing.Point(6, 66);
            this.InactiveCheckbox.Name = "InactiveCheckbox";
            this.InactiveCheckbox.Size = new System.Drawing.Size(91, 17);
            this.InactiveCheckbox.TabIndex = 4;
            this.InactiveCheckbox.Text = "Inactive Entry";
            this.InputsToolTip.SetToolTip(this.InactiveCheckbox, "Inactive Entry:\r\nIf the company is inactive, tick this and there is no need to ed" +
        "it anything else.");
            this.InactiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // NumDevStoresInput
            // 
            this.NumDevStoresInput.Location = new System.Drawing.Point(337, 42);
            this.NumDevStoresInput.Name = "NumDevStoresInput";
            this.NumDevStoresInput.Size = new System.Drawing.Size(39, 20);
            this.NumDevStoresInput.TabIndex = 3;
            this.InputsToolTip.SetToolTip(this.NumDevStoresInput, "Number of Developing Stores:\r\nNumber of stores being developed by this company.");
            // 
            // NumNewStoresInput
            // 
            this.NumNewStoresInput.Location = new System.Drawing.Point(130, 42);
            this.NumNewStoresInput.Name = "NumNewStoresInput";
            this.NumNewStoresInput.Size = new System.Drawing.Size(39, 20);
            this.NumNewStoresInput.TabIndex = 2;
            this.InputsToolTip.SetToolTip(this.NumNewStoresInput, "New Number of Stores:\r\nThe new amount of stores found.\r\nNote: Will automatically " +
        "be assigned at the end to the number of locations.");
            // 
            // BrandsGroupBox
            // 
            this.BrandsGroupBox.Controls.Add(this.BrandsInputLabel);
            this.BrandsGroupBox.Controls.Add(this.BrandsInput);
            this.BrandsGroupBox.Controls.Add(this.BrandsFlowLayout);
            this.BrandsGroupBox.Location = new System.Drawing.Point(4, 89);
            this.BrandsGroupBox.Name = "BrandsGroupBox";
            this.BrandsGroupBox.Size = new System.Drawing.Size(366, 131);
            this.BrandsGroupBox.TabIndex = 10;
            this.BrandsGroupBox.TabStop = false;
            this.BrandsGroupBox.Text = "Brands";
            // 
            // BrandsInputLabel
            // 
            this.BrandsInputLabel.AutoSize = true;
            this.BrandsInputLabel.Location = new System.Drawing.Point(6, 15);
            this.BrandsInputLabel.Name = "BrandsInputLabel";
            this.BrandsInputLabel.Size = new System.Drawing.Size(70, 13);
            this.BrandsInputLabel.TabIndex = 5;
            this.BrandsInputLabel.Text = "Brands Input:";
            // 
            // BrandsInput
            // 
            this.BrandsInput.Location = new System.Drawing.Point(79, 12);
            this.BrandsInput.Name = "BrandsInput";
            this.BrandsInput.Size = new System.Drawing.Size(280, 20);
            this.BrandsInput.TabIndex = 17;
            this.InputsToolTip.SetToolTip(this.BrandsInput, "Brands Input:\r\nInput for franchise brands this company is apart of, ex Starbucks " +
        "and McDonalds.\r\nSimply enter the data and press enter for it to be inputted.");
            this.BrandsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandsInput_KeyDown);
            // 
            // BrandsFlowLayout
            // 
            this.BrandsFlowLayout.AutoScroll = true;
            this.BrandsFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrandsFlowLayout.Location = new System.Drawing.Point(3, 33);
            this.BrandsFlowLayout.Name = "BrandsFlowLayout";
            this.BrandsFlowLayout.Size = new System.Drawing.Size(360, 95);
            this.BrandsFlowLayout.TabIndex = 3;
            this.InputsToolTip.SetToolTip(this.BrandsFlowLayout, "Brands Container:\r\nSimple Container for the brands.");
            // 
            // Num_Dev_StoresLabel
            // 
            this.Num_Dev_StoresLabel.AutoSize = true;
            this.Num_Dev_StoresLabel.Location = new System.Drawing.Point(190, 45);
            this.Num_Dev_StoresLabel.Name = "Num_Dev_StoresLabel";
            this.Num_Dev_StoresLabel.Size = new System.Drawing.Size(149, 13);
            this.Num_Dev_StoresLabel.TabIndex = 5;
            this.Num_Dev_StoresLabel.Text = "Number of Developing Stores:";
            // 
            // New_Num_StoresLabel
            // 
            this.New_Num_StoresLabel.AutoSize = true;
            this.New_Num_StoresLabel.Location = new System.Drawing.Point(7, 45);
            this.New_Num_StoresLabel.Name = "New_Num_StoresLabel";
            this.New_Num_StoresLabel.Size = new System.Drawing.Size(117, 13);
            this.New_Num_StoresLabel.TabIndex = 3;
            this.New_Num_StoresLabel.Text = "New Number of Stores:";
            // 
            // WebsiteInput
            // 
            this.WebsiteInput.Location = new System.Drawing.Point(59, 16);
            this.WebsiteInput.Name = "WebsiteInput";
            this.WebsiteInput.Size = new System.Drawing.Size(317, 20);
            this.WebsiteInput.TabIndex = 1;
            this.InputsToolTip.SetToolTip(this.WebsiteInput, "Website:\r\nThe Company\'s website input.\r\nMust be an actual URL.\r\nWill autoformat t" +
        "he url, getting rid of https and any extra information other than domain.\r\n");
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.Location = new System.Drawing.Point(7, 19);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(49, 13);
            this.WebsiteLabel.TabIndex = 1;
            this.WebsiteLabel.Text = "Website:";
            // 
            // LocationsGroupBox
            // 
            this.LocationsGroupBox.Controls.Add(this.SocialNameComboBox);
            this.LocationsGroupBox.Controls.Add(this.LocationBookingProviderInput);
            this.LocationsGroupBox.Controls.Add(this.LocationBookingProviderLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationsPanel);
            this.LocationsGroupBox.Controls.Add(this.SocialTagInput);
            this.LocationsGroupBox.Controls.Add(this.SocialsGroupBox);
            this.LocationsGroupBox.Controls.Add(this.SocialTagLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationAdd1Input);
            this.LocationsGroupBox.Controls.Add(this.LocationAddress1Label);
            this.LocationsGroupBox.Controls.Add(this.LocationPhoneNumberLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationAddress2Label);
            this.LocationsGroupBox.Controls.Add(this.LocationPhoneNumberInput);
            this.LocationsGroupBox.Controls.Add(this.LocationPostcodeInput);
            this.LocationsGroupBox.Controls.Add(this.SocialNameLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationAdd2Input);
            this.LocationsGroupBox.Controls.Add(this.LocationWebsiteInput);
            this.LocationsGroupBox.Controls.Add(this.LocationCityLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationWebsiteLabel);
            this.LocationsGroupBox.Controls.Add(this.LocationCityInput);
            this.LocationsGroupBox.Controls.Add(this.LocationPostcodeLabel);
            this.LocationsGroupBox.Controls.Add(this.AddSocialsButton);
            this.LocationsGroupBox.Controls.Add(this.LocationNameInput);
            this.LocationsGroupBox.Controls.Add(this.LocationNameLabel);
            this.LocationsGroupBox.Controls.Add(this.CreateLocationButton);
            this.LocationsGroupBox.Controls.Add(this.LocationsSavedLabel);
            this.LocationsGroupBox.Location = new System.Drawing.Point(400, 10);
            this.LocationsGroupBox.Name = "LocationsGroupBox";
            this.LocationsGroupBox.Size = new System.Drawing.Size(829, 688);
            this.LocationsGroupBox.TabIndex = 2;
            this.LocationsGroupBox.TabStop = false;
            this.LocationsGroupBox.Text = "Locations";
            // 
            // SocialNameComboBox
            // 
            this.SocialNameComboBox.DisplayMember = "10000";
            this.SocialNameComboBox.FormattingEnabled = true;
            this.SocialNameComboBox.Items.AddRange(new object[] {
            "youtube",
            "linkedin",
            "instagram",
            "twitter",
            "facebook",
            "tiktok",
            "snapchat",
            "pinterest"});
            this.SocialNameComboBox.Location = new System.Drawing.Point(336, 169);
            this.SocialNameComboBox.Name = "SocialNameComboBox";
            this.SocialNameComboBox.Size = new System.Drawing.Size(126, 21);
            this.SocialNameComboBox.TabIndex = 13;
            this.SocialNameComboBox.TabStop = false;
            this.SocialNameComboBox.Text = "Select Social Media";
            this.InputsToolTip.SetToolTip(this.SocialNameComboBox, "Social Name Dropdown:\r\nDropdown box containing Social Media names, this is to pro" +
        "vide consitency and remove human errors such as spelling mistakes.\r\n");
            // 
            // LocationBookingProviderInput
            // 
            this.LocationBookingProviderInput.Location = new System.Drawing.Point(147, 168);
            this.LocationBookingProviderInput.Name = "LocationBookingProviderInput";
            this.LocationBookingProviderInput.Size = new System.Drawing.Size(119, 20);
            this.LocationBookingProviderInput.TabIndex = 12;
            this.InputsToolTip.SetToolTip(this.LocationBookingProviderInput, "Location Booking Provider:\r\nBooking provider for the location, such as ResDiary, " +
        "or sevenrooms. Can be anything.\r\nNOTE: booking can be in terms of hotel booking," +
        " or resturant reservation booking.");
            // 
            // LocationBookingProviderLabel
            // 
            this.LocationBookingProviderLabel.AutoSize = true;
            this.LocationBookingProviderLabel.Location = new System.Drawing.Point(6, 172);
            this.LocationBookingProviderLabel.Name = "LocationBookingProviderLabel";
            this.LocationBookingProviderLabel.Size = new System.Drawing.Size(135, 13);
            this.LocationBookingProviderLabel.TabIndex = 1;
            this.LocationBookingProviderLabel.Text = "Location Booking Provider:";
            // 
            // LocationsPanel
            // 
            this.LocationsPanel.Controls.Add(this.LocationFlowLayout);
            this.LocationsPanel.Location = new System.Drawing.Point(8, 253);
            this.LocationsPanel.Name = "LocationsPanel";
            this.LocationsPanel.Size = new System.Drawing.Size(529, 413);
            this.LocationsPanel.TabIndex = 25;
            // 
            // SocialTagInput
            // 
            this.SocialTagInput.Location = new System.Drawing.Point(336, 194);
            this.SocialTagInput.Name = "SocialTagInput";
            this.SocialTagInput.Size = new System.Drawing.Size(126, 20);
            this.SocialTagInput.TabIndex = 14;
            this.InputsToolTip.SetToolTip(this.SocialTagInput, "Social Media Tag:\r\nThe social media tag, has to be correct.\r\nNOTE: Should not con" +
        "tain the @ Symbol\r\n");
            // 
            // SocialsGroupBox
            // 
            this.SocialsGroupBox.Controls.Add(this.SocialsLayoutContainer);
            this.SocialsGroupBox.Location = new System.Drawing.Point(562, 12);
            this.SocialsGroupBox.Name = "SocialsGroupBox";
            this.SocialsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SocialsGroupBox.Size = new System.Drawing.Size(261, 654);
            this.SocialsGroupBox.TabIndex = 14;
            this.SocialsGroupBox.TabStop = false;
            this.SocialsGroupBox.Text = "Socials";
            // 
            // SocialsLayoutContainer
            // 
            this.SocialsLayoutContainer.AutoScroll = true;
            this.SocialsLayoutContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialsLayoutContainer.Location = new System.Drawing.Point(3, 16);
            this.SocialsLayoutContainer.Name = "SocialsLayoutContainer";
            this.SocialsLayoutContainer.Size = new System.Drawing.Size(255, 629);
            this.SocialsLayoutContainer.TabIndex = 1;
            this.InputsToolTip.SetToolTip(this.SocialsLayoutContainer, "Location Social Media Locater:\r\nA container to hold the social media for a locati" +
        "on, will only show the locations for the social media yo are currently working o" +
        "n.");
            // 
            // SocialTagLabel
            // 
            this.SocialTagLabel.AutoSize = true;
            this.SocialTagLabel.Location = new System.Drawing.Point(269, 197);
            this.SocialTagLabel.Name = "SocialTagLabel";
            this.SocialTagLabel.Size = new System.Drawing.Size(61, 13);
            this.SocialTagLabel.TabIndex = 1;
            this.SocialTagLabel.Text = "Social Tag:";
            // 
            // LocationAdd1Input
            // 
            this.LocationAdd1Input.Location = new System.Drawing.Point(112, 94);
            this.LocationAdd1Input.Name = "LocationAdd1Input";
            this.LocationAdd1Input.Size = new System.Drawing.Size(404, 20);
            this.LocationAdd1Input.TabIndex = 8;
            this.InputsToolTip.SetToolTip(this.LocationAdd1Input, resources.GetString("LocationAdd1Input.ToolTip"));
            // 
            // LocationAddress1Label
            // 
            this.LocationAddress1Label.AutoSize = true;
            this.LocationAddress1Label.Location = new System.Drawing.Point(5, 97);
            this.LocationAddress1Label.Name = "LocationAddress1Label";
            this.LocationAddress1Label.Size = new System.Drawing.Size(101, 13);
            this.LocationAddress1Label.TabIndex = 1;
            this.LocationAddress1Label.Text = "Location Address 1:";
            // 
            // LocationPhoneNumberLabel
            // 
            this.LocationPhoneNumberLabel.AutoSize = true;
            this.LocationPhoneNumberLabel.Location = new System.Drawing.Point(6, 71);
            this.LocationPhoneNumberLabel.Name = "LocationPhoneNumberLabel";
            this.LocationPhoneNumberLabel.Size = new System.Drawing.Size(125, 13);
            this.LocationPhoneNumberLabel.TabIndex = 1;
            this.LocationPhoneNumberLabel.Text = "Location Phone Number:";
            // 
            // LocationAddress2Label
            // 
            this.LocationAddress2Label.AutoSize = true;
            this.LocationAddress2Label.Location = new System.Drawing.Point(5, 123);
            this.LocationAddress2Label.Name = "LocationAddress2Label";
            this.LocationAddress2Label.Size = new System.Drawing.Size(101, 13);
            this.LocationAddress2Label.TabIndex = 1;
            this.LocationAddress2Label.Text = "Location Address 2:";
            // 
            // LocationPhoneNumberInput
            // 
            this.LocationPhoneNumberInput.Location = new System.Drawing.Point(137, 68);
            this.LocationPhoneNumberInput.Name = "LocationPhoneNumberInput";
            this.LocationPhoneNumberInput.Size = new System.Drawing.Size(379, 20);
            this.LocationPhoneNumberInput.TabIndex = 7;
            this.InputsToolTip.SetToolTip(this.LocationPhoneNumberInput, resources.GetString("LocationPhoneNumberInput.ToolTip"));
            // 
            // LocationPostcodeInput
            // 
            this.LocationPostcodeInput.Location = new System.Drawing.Point(306, 146);
            this.LocationPostcodeInput.Name = "LocationPostcodeInput";
            this.LocationPostcodeInput.Size = new System.Drawing.Size(209, 20);
            this.LocationPostcodeInput.TabIndex = 11;
            this.InputsToolTip.SetToolTip(this.LocationPostcodeInput, "Location Postcode:\r\nThe postcode for the location, This is autoformatted.");
            // 
            // SocialNameLabel
            // 
            this.SocialNameLabel.AutoSize = true;
            this.SocialNameLabel.Location = new System.Drawing.Point(269, 175);
            this.SocialNameLabel.Name = "SocialNameLabel";
            this.SocialNameLabel.Size = new System.Drawing.Size(70, 13);
            this.SocialNameLabel.TabIndex = 1;
            this.SocialNameLabel.Text = "Social Name:";
            // 
            // LocationAdd2Input
            // 
            this.LocationAdd2Input.Location = new System.Drawing.Point(112, 120);
            this.LocationAdd2Input.Name = "LocationAdd2Input";
            this.LocationAdd2Input.Size = new System.Drawing.Size(404, 20);
            this.LocationAdd2Input.TabIndex = 9;
            this.InputsToolTip.SetToolTip(this.LocationAdd2Input, resources.GetString("LocationAdd2Input.ToolTip"));
            // 
            // LocationWebsiteInput
            // 
            this.LocationWebsiteInput.Location = new System.Drawing.Point(105, 43);
            this.LocationWebsiteInput.Name = "LocationWebsiteInput";
            this.LocationWebsiteInput.Size = new System.Drawing.Size(411, 20);
            this.LocationWebsiteInput.TabIndex = 6;
            this.InputsToolTip.SetToolTip(this.LocationWebsiteInput, resources.GetString("LocationWebsiteInput.ToolTip"));
            // 
            // LocationCityLabel
            // 
            this.LocationCityLabel.AutoSize = true;
            this.LocationCityLabel.Location = new System.Drawing.Point(5, 149);
            this.LocationCityLabel.Name = "LocationCityLabel";
            this.LocationCityLabel.Size = new System.Drawing.Size(71, 13);
            this.LocationCityLabel.TabIndex = 1;
            this.LocationCityLabel.Text = "Location City:";
            // 
            // LocationWebsiteLabel
            // 
            this.LocationWebsiteLabel.AutoSize = true;
            this.LocationWebsiteLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LocationWebsiteLabel.Location = new System.Drawing.Point(6, 46);
            this.LocationWebsiteLabel.Name = "LocationWebsiteLabel";
            this.LocationWebsiteLabel.Size = new System.Drawing.Size(93, 13);
            this.LocationWebsiteLabel.TabIndex = 1;
            this.LocationWebsiteLabel.Text = "Location Website:";
            // 
            // LocationCityInput
            // 
            this.LocationCityInput.Location = new System.Drawing.Point(82, 146);
            this.LocationCityInput.Name = "LocationCityInput";
            this.LocationCityInput.Size = new System.Drawing.Size(119, 20);
            this.LocationCityInput.TabIndex = 10;
            this.InputsToolTip.SetToolTip(this.LocationCityInput, "Location City:\r\nThe city this location is located in, usually included in the add" +
        "ress, if not found in address use google maps to find it.\r\n");
            // 
            // LocationPostcodeLabel
            // 
            this.LocationPostcodeLabel.AutoSize = true;
            this.LocationPostcodeLabel.Location = new System.Drawing.Point(201, 149);
            this.LocationPostcodeLabel.Name = "LocationPostcodeLabel";
            this.LocationPostcodeLabel.Size = new System.Drawing.Size(99, 13);
            this.LocationPostcodeLabel.TabIndex = 1;
            this.LocationPostcodeLabel.Text = "Location Postcode:";
            // 
            // AddSocialsButton
            // 
            this.AddSocialsButton.Location = new System.Drawing.Point(468, 172);
            this.AddSocialsButton.Name = "AddSocialsButton";
            this.AddSocialsButton.Size = new System.Drawing.Size(47, 42);
            this.AddSocialsButton.TabIndex = 15;
            this.AddSocialsButton.Text = "Add Social";
            this.InputsToolTip.SetToolTip(this.AddSocialsButton, "Add Social Button:\r\nWill create a social media item based on the inputs, the item" +
        " can be deleted if required.\r\nNOTE: This social media item is only visable and c" +
        "onnected to the location you create.\r\n");
            this.AddSocialsButton.UseVisualStyleBackColor = true;
            this.AddSocialsButton.Click += new System.EventHandler(this.AddSocialsButton_Click);
            // 
            // LocationNameInput
            // 
            this.LocationNameInput.Location = new System.Drawing.Point(94, 17);
            this.LocationNameInput.Name = "LocationNameInput";
            this.LocationNameInput.Size = new System.Drawing.Size(423, 20);
            this.LocationNameInput.TabIndex = 5;
            this.InputsToolTip.SetToolTip(this.LocationNameInput, "Location Name:\r\nThe name of the location, normally specified on the facebook, goo" +
        "gle maps or company website.");
            // 
            // LocationNameLabel
            // 
            this.LocationNameLabel.AutoSize = true;
            this.LocationNameLabel.Location = new System.Drawing.Point(6, 20);
            this.LocationNameLabel.Name = "LocationNameLabel";
            this.LocationNameLabel.Size = new System.Drawing.Size(82, 13);
            this.LocationNameLabel.TabIndex = 1;
            this.LocationNameLabel.Text = "Location Name:";
            // 
            // CreateLocationButton
            // 
            this.CreateLocationButton.Location = new System.Drawing.Point(440, 225);
            this.CreateLocationButton.Name = "CreateLocationButton";
            this.CreateLocationButton.Size = new System.Drawing.Size(75, 23);
            this.CreateLocationButton.TabIndex = 16;
            this.CreateLocationButton.Text = "Create";
            this.InputsToolTip.SetToolTip(this.CreateLocationButton, "Create Button:\r\nWill create the location based on the information above.\r\nNOTE: L" +
        "ocations once created, can be edited or deleted.");
            this.CreateLocationButton.UseVisualStyleBackColor = true;
            this.CreateLocationButton.Click += new System.EventHandler(this.CreateLocationButton_Click);
            // 
            // LocationsSavedLabel
            // 
            this.LocationsSavedLabel.AutoSize = true;
            this.LocationsSavedLabel.Location = new System.Drawing.Point(3, 237);
            this.LocationsSavedLabel.Name = "LocationsSavedLabel";
            this.LocationsSavedLabel.Size = new System.Drawing.Size(96, 13);
            this.LocationsSavedLabel.TabIndex = 1;
            this.LocationsSavedLabel.Text = "Created Locations:";
            // 
            // ExcelPanel
            // 
            this.ExcelPanel.Controls.Add(this.SelectFileButton);
            this.ExcelPanel.Controls.Add(this.ImportButton);
            this.ExcelPanel.Controls.Add(this.ToRowDropDown);
            this.ExcelPanel.Controls.Add(this.RowToRow);
            this.ExcelPanel.Controls.Add(this.FromRowDropDown);
            this.ExcelPanel.Controls.Add(this.SaveButton);
            this.ExcelPanel.Location = new System.Drawing.Point(6, 19);
            this.ExcelPanel.Name = "ExcelPanel";
            this.ExcelPanel.Size = new System.Drawing.Size(134, 135);
            this.ExcelPanel.TabIndex = 1;
            this.ExcelPanel.TabStop = false;
            this.ExcelPanel.Text = "Importer";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 97);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(50, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.TabStop = false;
            this.ImportButton.Text = "Import";
            this.InputsToolTip.SetToolTip(this.ImportButton, "Import Button:\r\nWill import based on the rows you chose above");
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ToRowDropDown
            // 
            this.ToRowDropDown.DisplayMember = "10000";
            this.ToRowDropDown.FormattingEnabled = true;
            this.ToRowDropDown.Location = new System.Drawing.Point(68, 74);
            this.ToRowDropDown.Name = "ToRowDropDown";
            this.ToRowDropDown.Size = new System.Drawing.Size(50, 21);
            this.ToRowDropDown.TabIndex = 14;
            this.ToRowDropDown.TabStop = false;
            this.InputsToolTip.SetToolTip(this.ToRowDropDown, "Row To:\r\nThe row you want to import to\r\n");
            // 
            // RowToRow
            // 
            this.RowToRow.Location = new System.Drawing.Point(11, 56);
            this.RowToRow.Name = "RowToRow";
            this.RowToRow.Size = new System.Drawing.Size(107, 13);
            this.RowToRow.TabIndex = 13;
            this.RowToRow.Text = "from Row to Row";
            this.RowToRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromRowDropDown
            // 
            this.FromRowDropDown.FormattingEnabled = true;
            this.FromRowDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.FromRowDropDown.Location = new System.Drawing.Point(14, 74);
            this.FromRowDropDown.Name = "FromRowDropDown";
            this.FromRowDropDown.Size = new System.Drawing.Size(50, 21);
            this.FromRowDropDown.TabIndex = 1;
            this.FromRowDropDown.TabStop = false;
            this.InputsToolTip.SetToolTip(this.FromRowDropDown, "Row From:\r\nThe row you want to import from");
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(68, 97);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.InputsToolTip.SetToolTip(this.SaveButton, "Save Button:\r\nWill save the data you\'ve worked on so far.\r\nNOTE: If nothing is in" +
        " the save as field, then will save\r\nthe data based on the \"Import File\", so it c" +
        "an overwrite data");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExcelControls
            // 
            this.ExcelControls.Controls.Add(this.CurrRowsContr);
            this.ExcelControls.Controls.Add(this.ExcelPanel);
            this.ExcelControls.Location = new System.Drawing.Point(12, 3);
            this.ExcelControls.Name = "ExcelControls";
            this.ExcelControls.Size = new System.Drawing.Size(376, 160);
            this.ExcelControls.TabIndex = 2;
            this.ExcelControls.TabStop = false;
            this.ExcelControls.Text = "Excel Controls";
            // 
            // CurrRowsContr
            // 
            this.CurrRowsContr.Controls.Add(this.SaveFileLabel);
            this.CurrRowsContr.Controls.Add(this.FileSaveNameInput);
            this.CurrRowsContr.Controls.Add(this.SaveRowButton);
            this.CurrRowsContr.Controls.Add(this.CompanyNameLabel);
            this.CurrRowsContr.Controls.Add(this.SelectButton);
            this.CurrRowsContr.Controls.Add(this.RowChooserDropDown);
            this.CurrRowsContr.Controls.Add(this.RowChooseLabel);
            this.CurrRowsContr.Controls.Add(this.RowNumberLabel);
            this.CurrRowsContr.Controls.Add(this.PreviousButton);
            this.CurrRowsContr.Controls.Add(this.NextButton);
            this.CurrRowsContr.Location = new System.Drawing.Point(146, 19);
            this.CurrRowsContr.Name = "CurrRowsContr";
            this.CurrRowsContr.Size = new System.Drawing.Size(224, 135);
            this.CurrRowsContr.TabIndex = 3;
            this.CurrRowsContr.TabStop = false;
            this.CurrRowsContr.Text = "Current Rows Controller";
            // 
            // SaveFileLabel
            // 
            this.SaveFileLabel.AutoSize = true;
            this.SaveFileLabel.Location = new System.Drawing.Point(6, 107);
            this.SaveFileLabel.Name = "SaveFileLabel";
            this.SaveFileLabel.Size = new System.Drawing.Size(50, 13);
            this.SaveFileLabel.TabIndex = 23;
            this.SaveFileLabel.Text = "Save As:";
            // 
            // FileSaveNameInput
            // 
            this.FileSaveNameInput.Location = new System.Drawing.Point(58, 104);
            this.FileSaveNameInput.Name = "FileSaveNameInput";
            this.FileSaveNameInput.Size = new System.Drawing.Size(158, 20);
            this.FileSaveNameInput.TabIndex = 18;
            this.FileSaveNameInput.TabStop = false;
            this.InputsToolTip.SetToolTip(this.FileSaveNameInput, "Save As:\r\nThe name of the file you want to save this as in C:\\ExcelData\r\nWARNING:" +
        " This can overwrite data, so watch out.");
            // 
            // SaveRowButton
            // 
            this.SaveRowButton.Location = new System.Drawing.Point(83, 56);
            this.SaveRowButton.Name = "SaveRowButton";
            this.SaveRowButton.Size = new System.Drawing.Size(119, 23);
            this.SaveRowButton.TabIndex = 18;
            this.SaveRowButton.TabStop = false;
            this.SaveRowButton.Text = "Save Row";
            this.InputsToolTip.SetToolTip(this.SaveRowButton, "Save Row Button:\r\nWill save the current row its on in the program ONLY, not in an" +
        "y excel file.");
            this.SaveRowButton.UseVisualStyleBackColor = true;
            this.SaveRowButton.Click += new System.EventHandler(this.SaveRowButton_Click);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(6, 82);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(85, 13);
            this.CompanyNameLabel.TabIndex = 22;
            this.CompanyNameLabel.Text = "Company Name:";
            this.InputsToolTip.SetToolTip(this.CompanyNameLabel, "Company Name:\r\nWill display the name of the company you are currently on. Is non-" +
        "editable");
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(6, 56);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(71, 23);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.TabStop = false;
            this.SelectButton.Text = "Select Row";
            this.InputsToolTip.SetToolTip(this.SelectButton, "Select Button:\r\nIt will load the row you selected in the Row Chooser dropdown.");
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // RowChooserDropDown
            // 
            this.RowChooserDropDown.FormattingEnabled = true;
            this.RowChooserDropDown.Location = new System.Drawing.Point(6, 32);
            this.RowChooserDropDown.Name = "RowChooserDropDown";
            this.RowChooserDropDown.Size = new System.Drawing.Size(71, 21);
            this.RowChooserDropDown.TabIndex = 20;
            this.RowChooserDropDown.TabStop = false;
            this.InputsToolTip.SetToolTip(this.RowChooserDropDown, "Row Chooser:\r\nYou can pick a specific row based on what you imported here.\r\nSimpl" +
        "e choose the row then click the select button.");
            // 
            // RowChooseLabel
            // 
            this.RowChooseLabel.AutoSize = true;
            this.RowChooseLabel.Location = new System.Drawing.Point(6, 16);
            this.RowChooseLabel.Name = "RowChooseLabel";
            this.RowChooseLabel.Size = new System.Drawing.Size(74, 13);
            this.RowChooseLabel.TabIndex = 19;
            this.RowChooseLabel.Text = "Row Chooser:";
            // 
            // RowNumberLabel
            // 
            this.RowNumberLabel.AutoSize = true;
            this.RowNumberLabel.Location = new System.Drawing.Point(86, 16);
            this.RowNumberLabel.Name = "RowNumberLabel";
            this.RowNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.RowNumberLabel.TabIndex = 18;
            this.RowNumberLabel.Text = "Row Number: 0001";
            this.InputsToolTip.SetToolTip(this.RowNumberLabel, "Row Number:\r\nWill display the row you are currently editing.\r\nNOTE: starts at 0, " +
        "due to c# index setup.");
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(83, 32);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(60, 23);
            this.PreviousButton.TabIndex = 17;
            this.PreviousButton.TabStop = false;
            this.PreviousButton.Text = "Previous";
            this.InputsToolTip.SetToolTip(this.PreviousButton, "Previous Button:\r\nWill go back 1 from the row you are currently on\r\nNote: Will sa" +
        "ve data in the file based off of \"save as\", if that is empty it will go for \"Imp" +
        "ort File\" entry.\r\n");
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(149, 32);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(53, 23);
            this.NextButton.TabIndex = 16;
            this.NextButton.TabStop = false;
            this.NextButton.Text = "Next";
            this.InputsToolTip.SetToolTip(this.NextButton, "Next Button:\r\nWill go further 1 from the row you are currently on\r\nNote: Will sav" +
        "e data in the file based off of \"save as\", if that is empty it will go for \"Impo" +
        "rt File\" entry.\r\n\r\n");
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // InputsToolTip
            // 
            this.InputsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InputsToolTip.ToolTipTitle = "Information for Inputs";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(11, 14);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(107, 39);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.TabStop = false;
            this.SelectFileButton.Text = "Select File";
            this.InputsToolTip.SetToolTip(this.SelectFileButton, "Select File Button:\r\nWill Allow you to get the rows and data from an excel file");
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // MainMenuInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 710);
            this.Controls.Add(this.ExcelControls);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.LocationsGroupBox);
            this.Name = "MainMenuInterface";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.CompanySocialsGroupBox.ResumeLayout(false);
            this.CompanySocialsGroupBox.PerformLayout();
            this.SocialsHolderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumDevStoresInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNewStoresInput)).EndInit();
            this.BrandsGroupBox.ResumeLayout(false);
            this.BrandsGroupBox.PerformLayout();
            this.LocationsGroupBox.ResumeLayout(false);
            this.LocationsGroupBox.PerformLayout();
            this.LocationsPanel.ResumeLayout(false);
            this.SocialsGroupBox.ResumeLayout(false);
            this.ExcelPanel.ResumeLayout(false);
            this.ExcelControls.ResumeLayout(false);
            this.CurrRowsContr.ResumeLayout(false);
            this.CurrRowsContr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox InputPanel;
        private System.Windows.Forms.TextBox WebsiteInput;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.GroupBox ExcelPanel;
        private System.Windows.Forms.Label New_Num_StoresLabel;
        private System.Windows.Forms.Label Num_Dev_StoresLabel;
        private System.Windows.Forms.GroupBox BrandsGroupBox;
        private System.Windows.Forms.GroupBox LocationsGroupBox;
        private System.Windows.Forms.NumericUpDown NumDevStoresInput;
        private System.Windows.Forms.NumericUpDown NumNewStoresInput;
        private System.Windows.Forms.Label RowToRow;
        private System.Windows.Forms.ComboBox FromRowDropDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox ToRowDropDown;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.GroupBox ExcelControls;
        private System.Windows.Forms.GroupBox CurrRowsContr;
        private System.Windows.Forms.ComboBox RowChooserDropDown;
        private System.Windows.Forms.Label RowChooseLabel;
        private System.Windows.Forms.Label RowNumberLabel;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label LocationAddress2Label;
        private System.Windows.Forms.Label LocationAddress1Label;
        private System.Windows.Forms.Label LocationNameLabel;
        private System.Windows.Forms.Button CreateLocationButton;
        private System.Windows.Forms.Label LocationsSavedLabel;
        private System.Windows.Forms.TextBox LocationCityInput;
        private System.Windows.Forms.Label LocationCityLabel;
        private System.Windows.Forms.TextBox LocationAdd2Input;
        private System.Windows.Forms.TextBox LocationAdd1Input;
        private System.Windows.Forms.TextBox LocationNameInput;
        private System.Windows.Forms.Label LocationPostcodeLabel;
        private System.Windows.Forms.GroupBox SocialsGroupBox;
        private System.Windows.Forms.Button AddSocialsButton;
        private System.Windows.Forms.TextBox LocationWebsiteInput;
        private System.Windows.Forms.Label LocationWebsiteLabel;
        private System.Windows.Forms.TextBox LocationPostcodeInput;
        private System.Windows.Forms.TextBox LocationPhoneNumberInput;
        private System.Windows.Forms.Label LocationPhoneNumberLabel;
        private System.Windows.Forms.TextBox SocialTagInput;
        private System.Windows.Forms.Label SocialTagLabel;
        private System.Windows.Forms.Label SocialNameLabel;
        public System.Windows.Forms.FlowLayoutPanel LocationFlowLayout;
        public System.Windows.Forms.FlowLayoutPanel SocialsLayoutContainer;
        private Label CompanyNameLabel;
        private Button SaveRowButton;
        private Label SaveFileLabel;
        private TextBox FileSaveNameInput;
        private Panel LocationsPanel;
        private TextBox LocationBookingProviderInput;
        private Label LocationBookingProviderLabel;
        private Label BrandsInputLabel;
        private TextBox BrandsInput;
        private FlowLayoutPanel BrandsFlowLayout;
        private CheckBox InactiveCheckbox;
        private GroupBox CompanySocialsGroupBox;
        private Panel SocialsHolderPanel;
        private FlowLayoutPanel CompanySocialsFlowLayout;
        private TextBox CompanySocialsTagInput;
        private Button AddCompanySocialButton;
        private Label CompanySocialsNameLabel;
        private Label CompanySocialsTagLabel;
        private ComboBox CompanySocialsNameComboBox;
        private ComboBox SocialNameComboBox;
        private ToolTip InputsToolTip;
        private Button SelectFileButton;
    }
}

