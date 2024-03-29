﻿using DanielleR_CPT_206_Lab_3.StateInformationDBDataSetTableAdapters;
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
    public partial class FormStateInfo : Form
    {
        

        public FormStateInfo()
        {
            InitializeComponent();
        }

        //Global Variable
        public string nameOfState = "";
        public string abbOfState = "";

        private void FormStateInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInformationDBDataSet.tblStateInfo' table. You can move, or remove it, as needed.
            this.tblStateInfoTableAdapter.Fill(this.stateInformationDBDataSet.tblStateInfo);
            //Changes Labels
            lblOutputStateName.Text = nameOfState;
            lblOutputStateABB.Text = abbOfState;

            //Change Pictures
            ChangePicsByState(nameOfState);

            FillByStateName2(nameOfState); //Testing if direct where query works and it does
        }
        private void ChangePicsByState(string state)
                {
                    switch (state)
                    {
                        case "Alabama":
                            picStateShape.Image = imageListStateIcon.Images[0];
                            picStateFlag.Image = imageListStateFlag.Images[0];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[0];
                            break;

                        case "Alaska":
                            picStateShape.Image = imageListStateIcon.Images[1];
                            picStateFlag.Image = imageListStateFlag.Images[1];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[1];
                            break;

                        case "Arizona":
                            picStateShape.Image = imageListStateIcon.Images[2];
                            picStateFlag.Image = imageListStateFlag.Images[2];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[2];
                            break;

                        case "Arkansas":
                            picStateShape.Image = imageListStateIcon.Images[3];
                            picStateFlag.Image = imageListStateFlag.Images[3];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[3];
                            break;

                        case "California":
                            picStateShape.Image = imageListStateIcon.Images[4];
                            picStateFlag.Image = imageListStateFlag.Images[4];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[4];
                            break;

                        case "Colorado":
                            picStateShape.Image = imageListStateIcon.Images[5];
                            picStateFlag.Image = imageListStateFlag.Images[5];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[5];
                            break;

                        case "Connecticut":
                            picStateShape.Image = imageListStateIcon.Images[6];
                            picStateFlag.Image = imageListStateFlag.Images[6];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[6];
                            break;

                        case "Delaware":
                            picStateShape.Image = imageListStateIcon.Images[7];
                            picStateFlag.Image = imageListStateFlag.Images[7];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[7];
                            break;

                        case "Florida":
                            picStateShape.Image = imageListStateIcon.Images[8];
                            picStateFlag.Image = imageListStateFlag.Images[8];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[8];
                            break;

                        case "Georgia":
                            picStateShape.Image = imageListStateIcon.Images[9];
                            picStateFlag.Image = imageListStateFlag.Images[9];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[9];
                            break;

                        case "Hawaii":
                            picStateShape.Image = imageListStateIcon.Images[10];
                            picStateFlag.Image = imageListStateFlag.Images[10];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[10];
                            break;

                        case "Idaho":
                            picStateShape.Image = imageListStateIcon.Images[11];
                            picStateFlag.Image = imageListStateFlag.Images[11];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[11];
                            break;

                        case "Illinois":
                            picStateShape.Image = imageListStateIcon.Images[12];
                            picStateFlag.Image = imageListStateFlag.Images[12];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[12];
                            break;

                        case "Indiana":
                            picStateShape.Image = imageListStateIcon.Images[13];
                            picStateFlag.Image = imageListStateFlag.Images[13];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[13];
                            break;

                        case "Iowa":
                            picStateShape.Image = imageListStateIcon.Images[14];
                            picStateFlag.Image = imageListStateFlag.Images[14];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[14];
                            break;

                        case "Kansas":
                            picStateShape.Image = imageListStateIcon.Images[15];
                            picStateFlag.Image = imageListStateFlag.Images[15];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[15];
                            break;

                        case "Kentucky":
                            picStateShape.Image = imageListStateIcon.Images[16];
                            picStateFlag.Image = imageListStateFlag.Images[16];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[16];
                            break;

                        case "Louisiana":
                            picStateShape.Image = imageListStateIcon.Images[17];
                            picStateFlag.Image = imageListStateFlag.Images[17];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[17];
                            break;

                        case "Maine":
                            picStateShape.Image = imageListStateIcon.Images[18];
                            picStateFlag.Image = imageListStateFlag.Images[18];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[18];
                            break;

                        case "Maryland":
                            picStateShape.Image = imageListStateIcon.Images[19];
                            picStateFlag.Image = imageListStateFlag.Images[19];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[19];
                            break;

                        case "Massassachusetts":
                            picStateShape.Image = imageListStateIcon.Images[20];
                            picStateFlag.Image = imageListStateFlag.Images[20];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[20];
                            break;

                        case "Michigan":
                            picStateShape.Image = imageListStateIcon.Images[21];
                            picStateFlag.Image = imageListStateFlag.Images[21];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[21];
                            break;

                        case "Minnesota":
                            picStateShape.Image = imageListStateIcon.Images[22];
                            picStateFlag.Image = imageListStateFlag.Images[22];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[22];
                            break;

                        case "Mississippi":
                            picStateShape.Image = imageListStateIcon.Images[23];
                            picStateFlag.Image = imageListStateFlag.Images[23];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[23];
                            break;

                        case "Missouri":
                            picStateShape.Image = imageListStateIcon.Images[24];
                            picStateFlag.Image = imageListStateFlag.Images[24];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[24];
                            break;

                        case "Montana":
                            picStateShape.Image = imageListStateIcon.Images[25];
                            picStateFlag.Image = imageListStateFlag.Images[25];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[25];
                            break;

                        case "Nebraska":
                            picStateShape.Image = imageListStateIcon.Images[26];
                            picStateFlag.Image = imageListStateFlag.Images[26];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[26];
                            break;

                        case "Nevada":
                            picStateShape.Image = imageListStateIcon.Images[27];
                            picStateFlag.Image = imageListStateFlag.Images[27];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[27];
                            break;

                        case "New Hampshire":
                            picStateShape.Image = imageListStateIcon.Images[28];
                            picStateFlag.Image = imageListStateFlag.Images[28];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[28];
                            break;

                        case "New Jersey":
                            picStateShape.Image = imageListStateIcon.Images[29];
                            picStateFlag.Image = imageListStateFlag.Images[29];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[29];
                            break;

                        case "New Mexico":
                            picStateShape.Image = imageListStateIcon.Images[30];
                            picStateFlag.Image = imageListStateFlag.Images[30];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[30];
                            break;

                        case "New York":
                            picStateShape.Image = imageListStateIcon.Images[31];
                            picStateFlag.Image = imageListStateFlag.Images[31];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[31];
                            break;

                        case "North Carolina":
                            picStateShape.Image = imageListStateIcon.Images[32];
                            picStateFlag.Image = imageListStateFlag.Images[32];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[32];
                            break;

                        case "North Dakota":
                            picStateShape.Image = imageListStateIcon.Images[33];
                            picStateFlag.Image = imageListStateFlag.Images[33];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[33];
                            break;

                        case "Ohio":
                            picStateShape.Image = imageListStateIcon.Images[34];
                            picStateFlag.Image = imageListStateFlag.Images[34];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[34];
                            break;

                        case "Oklahoma":
                            picStateShape.Image = imageListStateIcon.Images[35];
                            picStateFlag.Image = imageListStateFlag.Images[35];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[35];
                            break;

                        case "Oregon":
                            picStateShape.Image = imageListStateIcon.Images[36];
                            picStateFlag.Image = imageListStateFlag.Images[36];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[36];
                            break;

                        case "Pennsylvania":
                            picStateShape.Image = imageListStateIcon.Images[37];
                            picStateFlag.Image = imageListStateFlag.Images[37];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[37];
                            break;

                        case "Rhode Island":
                            picStateShape.Image = imageListStateIcon.Images[38];
                            picStateFlag.Image = imageListStateFlag.Images[38];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[38];
                            break;

                        case "South Carolina":
                            picStateShape.Image = imageListStateIcon.Images[39];
                            picStateFlag.Image = imageListStateFlag.Images[39];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[39];
                            break;

                        case "South Dakota":
                            picStateShape.Image = imageListStateIcon.Images[40];
                            picStateFlag.Image = imageListStateFlag.Images[40];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[40];
                            break;

                        case "Tennessee":
                            picStateShape.Image = imageListStateIcon.Images[41];
                            picStateFlag.Image = imageListStateFlag.Images[41];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[41];
                            break;

                        case "Texas":
                            picStateShape.Image = imageListStateIcon.Images[42];
                            picStateFlag.Image = imageListStateFlag.Images[42];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[42];
                            break;

                        case "Utah":
                            picStateShape.Image = imageListStateIcon.Images[43];
                            picStateFlag.Image = imageListStateFlag.Images[43];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[43];
                            break;

                        case "Vermont":
                            picStateShape.Image = imageListStateIcon.Images[44];
                            picStateFlag.Image = imageListStateFlag.Images[44];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[44];
                            break;

                        case "Virginia":
                            picStateShape.Image = imageListStateIcon.Images[45];
                            picStateFlag.Image = imageListStateFlag.Images[45];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[45];
                            break;

                        case "Washington":
                            picStateShape.Image = imageListStateIcon.Images[46];
                            picStateFlag.Image = imageListStateFlag.Images[46];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[46];
                            break;

                        case "West Virginia":
                            picStateShape.Image = imageListStateIcon.Images[47];
                            picStateFlag.Image = imageListStateFlag.Images[47];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[47];
                            break;

                        case "Wisconsin":
                            picStateShape.Image = imageListStateIcon.Images[48];
                            picStateFlag.Image = imageListStateFlag.Images[48];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[48];
                            break;

                        case "Wyoming":
                            picStateShape.Image = imageListStateIcon.Images[49];
                            picStateFlag.Image = imageListStateFlag.Images[49];
                            picStateFlowerBird.Image = imageListStateFlowerBird.Images[49];
                            break;
                    }
                }             

        private void FillByStateName(string abb)
        {
            //This doesn't fill the data set for some reason
            tblStateInfoTableAdapter.FillByStateName(this.stateInformationDBDataSet.tblStateInfo, abb);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void tblStateInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInformationDBDataSet);
        }

        private void FillByStateName2(string name) //Test Method
        {
            switch (name)
            {
                case "Alabama":
                    tblStateInfoTableAdapter.FillByAlabama(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Alaska":
                    tblStateInfoTableAdapter.FillByAlaska(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Arizona":
                    tblStateInfoTableAdapter.FillByArizona(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Arkansas":
                    tblStateInfoTableAdapter.FillByArkansas(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "California":
                    tblStateInfoTableAdapter.FillByCalifornia(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Colorado":
                    tblStateInfoTableAdapter.FillByColorado(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Connecticut":
                    tblStateInfoTableAdapter.FillByConnecticut(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Delaware":
                    tblStateInfoTableAdapter.FillByDelaware(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Florida":
                    tblStateInfoTableAdapter.FillByFlorida(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Georgia":
                    tblStateInfoTableAdapter.FillByGeorgia(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Hawaii":
                    tblStateInfoTableAdapter.FillByHawaii(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Idaho":
                    tblStateInfoTableAdapter.FillByIdaho(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Illinois":
                    tblStateInfoTableAdapter.FillByIllinois(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Indiana":
                    tblStateInfoTableAdapter.FillByIndiana(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Iowa":
                    tblStateInfoTableAdapter.FillByIowa(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Kansas":
                    tblStateInfoTableAdapter.FillByKansas(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Kentucky":
                    tblStateInfoTableAdapter.FillByKentucky(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Louisiana":
                    tblStateInfoTableAdapter.FillByLouisiana(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Maine":
                    tblStateInfoTableAdapter.FillByMaine(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Maryland":
                    tblStateInfoTableAdapter.FillByMaryland(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Massachusetts":
                    tblStateInfoTableAdapter.FillByMassachusetts(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Michigan":
                    tblStateInfoTableAdapter.FillByMichigan(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Minnesota":
                    tblStateInfoTableAdapter.FillByMinnesota(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Mississippi":
                    tblStateInfoTableAdapter.FillByMississippi(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Missouri":
                    tblStateInfoTableAdapter.FillByMissouri(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Montana":
                    tblStateInfoTableAdapter.FillByMontana(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Nebraska":
                    tblStateInfoTableAdapter.FillByNebraska(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Nevada":
                    tblStateInfoTableAdapter.FillByNevada(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "New Hampshire":
                    tblStateInfoTableAdapter.FillByNewHampshire(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "New Jersey":
                    tblStateInfoTableAdapter.FillByNewJersey(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "New Mexico":
                    tblStateInfoTableAdapter.FillByNewMexico(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "New York":
                    tblStateInfoTableAdapter.FillByNewYork(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "North Carolina":
                    tblStateInfoTableAdapter.FillByNorthCarolina(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "North Dakota":
                    tblStateInfoTableAdapter.FillByNorthDakota(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Ohio":
                    tblStateInfoTableAdapter.FillByOhio(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Oklahoma":
                    tblStateInfoTableAdapter.FillByOklahoma(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Oregon":
                    tblStateInfoTableAdapter.FillByOregon(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Pennsylvania":
                    tblStateInfoTableAdapter.FillByPennsylvania(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Rhode Island":
                    tblStateInfoTableAdapter.FillByRhodeIsland(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "South Carolina":
                    tblStateInfoTableAdapter.FillBySouthCarolina(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "South Dakota":
                    tblStateInfoTableAdapter.FillBySouthDakota(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Tennessee":
                    tblStateInfoTableAdapter.FillByTennessee(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Texas":
                    tblStateInfoTableAdapter.FillByTexas(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Utah":
                    tblStateInfoTableAdapter.FillByUtah(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Vermont":
                    tblStateInfoTableAdapter.FillByVermont(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Virginia":
                    tblStateInfoTableAdapter.FillByVirginia(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Washington":
                    tblStateInfoTableAdapter.FillByWashington(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "West Virginia":
                    tblStateInfoTableAdapter.FillByWestVirginia(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Wisconsin":
                    tblStateInfoTableAdapter.FillByWisconsin(this.stateInformationDBDataSet.tblStateInfo);
                    break;
                case "Wyoming":
                    tblStateInfoTableAdapter.FillByWyoming(this.stateInformationDBDataSet.tblStateInfo);
                    break;
            }
        }
    }
}
