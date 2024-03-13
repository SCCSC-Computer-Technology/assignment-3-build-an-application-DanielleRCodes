namespace DanielleR_CPT_206_Lab_3
{
    partial class StateSelectionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateSelectionUserControl));
            this.picState = new System.Windows.Forms.PictureBox();
            this.lblNameOfState = new System.Windows.Forms.Label();
            this.lblStateAbbr = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picState)).BeginInit();
            this.SuspendLayout();
            // 
            // picState
            // 
            this.picState.Image = ((System.Drawing.Image)(resources.GetObject("picState.Image")));
            this.picState.Location = new System.Drawing.Point(19, 11);
            this.picState.Name = "picState";
            this.picState.Size = new System.Drawing.Size(121, 117);
            this.picState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picState.TabIndex = 0;
            this.picState.TabStop = false;
            // 
            // lblNameOfState
            // 
            this.lblNameOfState.AutoSize = true;
            this.lblNameOfState.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfState.Location = new System.Drawing.Point(169, 34);
            this.lblNameOfState.Name = "lblNameOfState";
            this.lblNameOfState.Size = new System.Drawing.Size(163, 29);
            this.lblNameOfState.TabIndex = 1;
            this.lblNameOfState.Text = "South Carolina";
            // 
            // lblStateAbbr
            // 
            this.lblStateAbbr.AutoSize = true;
            this.lblStateAbbr.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAbbr.Location = new System.Drawing.Point(169, 75);
            this.lblStateAbbr.Name = "lblStateAbbr";
            this.lblStateAbbr.Size = new System.Drawing.Size(55, 29);
            this.lblStateAbbr.TabIndex = 2;
            this.lblStateAbbr.Text = "(SC)";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(415, 41);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(191, 49);
            this.btnViewDetails.TabIndex = 3;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Visible = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.MouseEnter += new System.EventHandler(this.btnViewDetails_MouseEnter);
            // 
            // StateSelectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lblStateAbbr);
            this.Controls.Add(this.lblNameOfState);
            this.Controls.Add(this.picState);
            this.Name = "StateSelectionUserControl";
            this.Size = new System.Drawing.Size(634, 139);
            this.Click += new System.EventHandler(this.StateSelectionUserControl_Click);
            this.MouseEnter += new System.EventHandler(this.StateSelectionUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.StateSelectionUserControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picState;
        private System.Windows.Forms.Label lblStateAbbr;
        private System.Windows.Forms.Button btnViewDetails;
        public System.Windows.Forms.Label lblNameOfState;
    }
}
