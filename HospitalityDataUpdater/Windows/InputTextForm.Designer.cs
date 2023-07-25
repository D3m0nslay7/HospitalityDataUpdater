namespace HospitalityDataUpdater.Windows
{
    partial class ImportForm
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
            this.PromptLabel = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            this.PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.Location = new System.Drawing.Point(6, 9);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(400, 107);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "Please Input XYZ";
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(90, 119);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(235, 20);
            this.InputTextbox.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(331, 119);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 3;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 194);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.PromptLabel);
            this.Name = "ImportForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button InputButton;
        public System.Windows.Forms.Label PromptLabel;
    }
}