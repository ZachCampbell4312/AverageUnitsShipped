namespace AverageUnitsShipped
{
    partial class AverageUnitsShipped
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
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textboxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(37, 34);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(35, 23);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            this.labelUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUnitsPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxEntryNumber
            // 
            this.textboxEntryNumber.Location = new System.Drawing.Point(133, 31);
            this.textboxEntryNumber.Name = "textboxEntryNumber";
            this.textboxEntryNumber.Size = new System.Drawing.Size(47, 20);
            this.textboxEntryNumber.TabIndex = 1;
            this.toolTip.SetToolTip(this.textboxEntryNumber, "Enter the units shipped for the specified day");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(224, 34);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPastEntries
            // 
            this.textBoxPastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPastEntries.Location = new System.Drawing.Point(78, 60);
            this.textBoxPastEntries.Multiline = true;
            this.textBoxPastEntries.Name = "textBoxPastEntries";
            this.textBoxPastEntries.ReadOnly = true;
            this.textBoxPastEntries.Size = new System.Drawing.Size(171, 154);
            this.textBoxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastEntries, "Displays the units shipped for all days entered");
            this.textBoxPastEntries.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(40, 226);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(247, 23);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average units shipped for the week");
            this.labelAverageOutput.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(40, 258);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(133, 258);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to allow a new set of entries");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(226, 258);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // AverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(341, 293);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxPastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxEntryNumber);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.AverageUnitsShipped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textboxEntryNumber;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

