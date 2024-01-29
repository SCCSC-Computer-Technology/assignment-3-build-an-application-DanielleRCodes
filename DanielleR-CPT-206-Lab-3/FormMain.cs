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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Global Variables
        List<StateSelectionUserControl> listStateControls = new List<StateSelectionUserControl>();
        //public FormMain main = new FormMain();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAdvFeatures_Click(object sender, EventArgs e)
        {
            //Opens the Sort and Filter Form
            FormAdvFeatures formAdv = new FormAdvFeatures();
            formAdv.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            //Iterates through the controls in the flowpanel and adds them to the list
            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                listStateControls.Add(c);
            }            
        }

        private void btnAllStates_Click(object sender, EventArgs e)
        {
            //This loops through the controls in the flowpanel and turns them visible
            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                c.Visible = true;
            }
        }

        private void btnStatesAE_Click(object sender, EventArgs e)
        {
            /*This loops through all the controls and gets the first char of the states name
             and stores it in the firstChar variable then uses a switch to compare whether it 
            should be visible or not depending on the buttons range*/ 

            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                char firstChar = char.ToLower(c.lblNameOfState.Text[0]);

                switch (firstChar)
                {
                    case 'a':
                        c.Visible = true; break;
                    case 'b':
                        c.Visible = true; break;
                    case 'c':
                        c.Visible = true; break;
                    case 'd':
                        c.Visible = true; break;
                    case 'e':
                        c.Visible = true; break;
                    default: 
                        c.Visible = false; break;
                }
            }
        }

        private void btnStatesFJ_Click(object sender, EventArgs e)
        {
            /*This loops through all the controls and gets the first char of the states name
             and stores it in the firstChar variable then uses a switch to compare whether it 
            should be visible or not depending on the buttons range*/

            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                char firstChar = char.ToLower(c.lblNameOfState.Text[0]);

                switch (firstChar)
                {
                    case 'f':
                        c.Visible = true; break;
                    case 'g':
                        c.Visible = true; break;
                    case 'h':
                        c.Visible = true; break;
                    case 'i':
                        c.Visible = true; break;
                    case 'j':
                        c.Visible = true; break;
                    default:
                        c.Visible = false; break;
                }
            }
        }

        private void btnStatesKO_Click(object sender, EventArgs e)
        {
            /*This loops through all the controls and gets the first char of the states name
             and stores it in the firstChar variable then uses a switch to compare whether it 
            should be visible or not depending on the buttons range*/

            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                char firstChar = char.ToLower(c.lblNameOfState.Text[0]);

                switch (firstChar)
                {
                    case 'k':
                        c.Visible = true; break;
                    case 'l':
                        c.Visible = true; break;
                    case 'm':
                        c.Visible = true; break;
                    case 'n':
                        c.Visible = true; break;
                    case 'o':
                        c.Visible = true; break;
                    default:
                        c.Visible = false; break;
                }
            }
        }

        private void btnStatesPT_Click(object sender, EventArgs e)
        {
            /*This loops through all the controls and gets the first char of the states name
             and stores it in the firstChar variable then uses a switch to compare whether it 
            should be visible or not depending on the buttons range*/

            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                char firstChar = char.ToLower(c.lblNameOfState.Text[0]);

                switch (firstChar)
                {
                    case 'p':
                        c.Visible = true; break;
                    case 'q':
                        c.Visible = true; break;
                    case 'r':
                        c.Visible = true; break;
                    case 's':
                        c.Visible = true; break;
                    case 't':
                        c.Visible = true; break;
                    default:
                        c.Visible = false; break;
                }
            }
        }

        private void btnStatesUZ_Click(object sender, EventArgs e)
        {
            /*This loops through all the controls and gets the first char of the states name
             and stores it in the firstChar variable then uses a switch to compare whether it 
            should be visible or not depending on the buttons range*/

            foreach (StateSelectionUserControl c in flowLayoutPanelAllStates.Controls)
            {
                char firstChar = char.ToLower(c.lblNameOfState.Text[0]);

                switch (firstChar)
                {
                    case 'u':
                        c.Visible = true; break;
                    case 'v':
                        c.Visible = true; break;
                    case 'w':
                        c.Visible = true; break;
                    case 'x':
                        c.Visible = true; break;
                    case 'y':
                        c.Visible = true; break;
                    case 'z':
                        c.Visible = true; break;
                    default:
                        c.Visible = false; break;
                }
            }
        }

        private void btnSearchTxt_Click(object sender, EventArgs e)
        {
            //Local Variables
            string userText = txtSearchbyName.Text;
            bool vaildEntry = false;

            //This tests the list on controls without manipulating the controls in the flowpanel
            foreach (StateSelectionUserControl c in listStateControls)
            {
                if (userText == c.lblNameOfState.Text)
                {
                    vaildEntry = true;                   
                }                             
            }

            /*If the user entered correct data then find correct one in flowpanel
            and hide all others*/

            if (vaildEntry == true)
            {
                foreach (StateSelectionUserControl s in flowLayoutPanelAllStates.Controls)
                {
                    if (userText == s.lblNameOfState.Text)
                    {
                        s.Visible = true;
                    }
                    else
                    {
                        s.Visible = false;
                    }
                }
            }
            else if (vaildEntry == false)
            {
                MessageBox.Show("Please Enter a Valid State!");
            }
        }      
    }
}
