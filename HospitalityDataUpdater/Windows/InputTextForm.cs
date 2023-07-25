using HospitalityDataUpdater.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalityDataUpdater.Windows
{
    partial class ImportForm : Form
    {

        public string UserInput { get; private set; }

        public ImportForm()
        {
            InitializeComponent();
        }


        private void InputButton_Click(object sender, EventArgs e) // If input button is clicked, we send the text back
        {
            UserInput = InputTextbox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) // if canceled, we leave the menu
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    
}

// This is a static class that provides a helper method for displaying a dialog box with a text input.
public static class InputBox
{
    // The Show method displays the input box dialog and returns the user's input or null if canceled.
    public static string Show(string title, string prompt)
    {
        // Create a new instance of the InputTextForm.
        // The 'using' statement ensures that the form will be properly disposed of after use.
        using (var form = new ImportForm())
        {
            // Set the title and prompt message for the input box form.
            form.Text = title;
            form.PromptLabel.Text = prompt;

            // Show the form as a modal dialog, meaning it will block the user interaction with other forms
            // until the dialog is closed.
            if (form.ShowDialog() == DialogResult.OK)
            {
                // If the user clicked OK and provided input, return the user's input.
                return form.UserInput;
            }
            else
            {
                // If the user canceled or closed the dialog without providing input, return null.
                return null;
            }
        }
    }
}
