using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleR_CPT_206_Lab_3
{
    public partial class StateSelectionUserControl : UserControl
    {
        public StateSelectionUserControl()
        {
            InitializeComponent();
        }

        //Backing Fields
        private string _stateName;
        private string _stateABB;
        private Image _stateIcon;        

        //Properties
        [Category("Custom Properties")] //Adds it to the Properties Pane
        public string StateName
        {
            // Adds the value the user sent to the field and updates the label on the Control
            get { return _stateName; }
            set { _stateName = value; lblNameOfState.Text = value; }
        }

        [Category("Custom Properties")] //Adds it to the Properties Pane
        public string StateABB
        {
            // Adds the value the user sent to the field and updates the label on the Control
            get { return _stateABB; }
            set { _stateABB = value; lblStateAbbr.Text = value; }
        }

        [Category("Custom Properties")] //Adds it to the Properties Pane
        public Image StateIcon
        {
            //Allows picture to be updated in the properties pane
            get { return _stateIcon; }
            set { _stateIcon = value; picState.Image = value; }
        }
      
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            string thisState = lblNameOfState.Text;
            string thisStateAbbr = lblStateAbbr.Text;

            FormStateInfo formStateInfo = new FormStateInfo();
            formStateInfo.nameOfState = thisState;
            formStateInfo.abbOfState = thisStateAbbr;
            formStateInfo.ShowDialog();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            string thisState = lblNameOfState.Text;
            string thisStateAbbr = lblStateAbbr.Text;

            FormStateInfo formStateInfo = new FormStateInfo();
            formStateInfo.nameOfState = thisState;
            formStateInfo.abbOfState = thisStateAbbr;
            formStateInfo.ShowDialog();
        }

        private void StateSelectionUserControl_MouseEnter(object sender, EventArgs e)
        {
            //When the mouse enters the controls space the color changes
            string controlColor = "#274265";    //hexcode of the highlighted control color

            Color color = System.Drawing.ColorTranslator.FromHtml(controlColor);

            this.BackColor = color;
            this.lblNameOfState.ForeColor = Color.White;
            this.lblStateAbbr.ForeColor = Color.White;            
        }

        private void StateSelectionUserControl_MouseLeave(object sender, EventArgs e)
        {
            //When the mouse leaves the controls space it resets the color to default 
           
            this.ReturnControlToDefault();               
        }       

        private void StateSelectionUserControl_Click(object sender, EventArgs e)
        {  
            //When the control is clicked it loops through the flowpanel and if the 
            //buttons the controls are visible it turns them off. It then turns this 
            //controls buttons on. This keeps only one set of control buttons visible
            //so that users can only select one state control at a time

            foreach (StateSelectionUserControl c in this.Parent.Controls)
            {
                if (c.btnViewDetails.Visible == true)
                {                  
                    c.btnViewDetails.Visible = false;
                }                
            }
            this.btnViewDetails.Visible = true;         
        }

        public void ReturnControlToDefault()
        {           
            string controlColor = "#7CC0CD";
            Color color = System.Drawing.ColorTranslator.FromHtml(controlColor);
          
            this.lblStateAbbr.ForeColor = Color.Black;
            this.lblNameOfState.ForeColor= Color.Black;          
            this.BackColor = color;
        }

        private void btnViewDetails_MouseEnter(object sender, EventArgs e)
        {
            string controlColor = "#274265";    //hexcode of the highlighted control color

            Color color = System.Drawing.ColorTranslator.FromHtml(controlColor);

            this.BackColor = color;
            this.lblStateAbbr.ForeColor = Color.White;
            this.lblNameOfState.ForeColor = Color.White;
        }
    }
}
