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
    public partial class FormAdvFeatures : Form
    {
        public FormAdvFeatures()
        {
            InitializeComponent();
        }

        //add reset form button

        private void tblStateInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInformationDBDataSet);

        }

        private void FormAdvFeatures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInformationDBDataSet.tblStateInfo' table. You can move, or remove it, as needed.
            this.tblStateInfoTableAdapter.Fill(this.stateInformationDBDataSet.tblStateInfo);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortASC_Click(object sender, EventArgs e)
        {
            string userSelection = cboxColumnsToSort.Text;

            switch (userSelection)
            {
                case "Abbreviation":
                    this.tblStateInfoTableAdapter.OrderByAbbASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Name":
                    this.tblStateInfoTableAdapter.OrderByNameASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Flower":
                    this.tblStateInfoTableAdapter.OrderByFlowerASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Bird":
                    this.tblStateInfoTableAdapter.OrderByBirdASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Colors":
                    this.tblStateInfoTableAdapter.OrderByColorsASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Flag Description":
                    this.tblStateInfoTableAdapter.OrderByFlagASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Population":
                    this.tblStateInfoTableAdapter.OrderByPopASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Median Income":
                    this.tblStateInfoTableAdapter.OrderByIncomeASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Largest City":
                    this.tblStateInfoTableAdapter.OrderByLargestCityASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Second Largest City":
                    this.tblStateInfoTableAdapter.OrderBySecLargestCityASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Third Largest City":
                    this.tblStateInfoTableAdapter.OrderByThirdLargestCityASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Percentage Comp Jobs":
                    this.tblStateInfoTableAdapter.OrderByCompJobsASC(this.stateInformationDBDataSet.tblStateInfo);
                    break;
            }
        }

        private void btnSortByDESC_Click(object sender, EventArgs e)
        {
            string userSelection = cboxColumnsToSort.Text;

            switch (userSelection)
            {
                case "Abbreviation":
                    this.tblStateInfoTableAdapter.OrderByAbbDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Name":
                    this.tblStateInfoTableAdapter.OrderByNameDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Flower":
                    this.tblStateInfoTableAdapter.OrderByFlowerDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Bird":
                    this.tblStateInfoTableAdapter.OrderByBirdDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Colors":
                    this.tblStateInfoTableAdapter.OrderByColorsDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Flag Description":
                    this.tblStateInfoTableAdapter.OrderByFlagDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Population":
                    this.tblStateInfoTableAdapter.OrderByPopDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Median Income":
                    this.tblStateInfoTableAdapter.OrderByIncomeDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Largest City":
                    this.tblStateInfoTableAdapter.OrderByLargestCityDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Second Largest City":
                    this.tblStateInfoTableAdapter.OrderBySecLargestCityDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Third Largest City":
                    this.tblStateInfoTableAdapter.OrderByThirdLargestCityDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;

                case "Percentage Comp Jobs":
                    this.tblStateInfoTableAdapter.OrderByCompJobsDESC(this.stateInformationDBDataSet.tblStateInfo);
                    break;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            string userSelection = cboxFilterData.Text;
            decimal average = 0.0m;

            switch (userSelection)
            {
                case "Population":
                    average = (decimal)this.tblStateInfoTableAdapter.AvgPopulation();
                    lblOutputAverage.Text = "National Population Average: " + average.ToString("N");
                    break;
                case "Median Income":
                    average = (decimal)this.tblStateInfoTableAdapter.AvgIncome();
                    lblOutputAverage.Text = "National Median Income: " + average.ToString("c");
                    break;
                case "Percentage Comp Jobs":
                    average = (decimal)this.tblStateInfoTableAdapter.AvgCompJobs();
                    lblOutputAverage.Text = "National Computer Job Average: " + average.ToString() + " %";
                    break;
            }
        }
    }
}
