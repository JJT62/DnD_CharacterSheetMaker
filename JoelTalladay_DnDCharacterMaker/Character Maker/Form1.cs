using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Character_Maker
{
    public partial class Form1 : Form
    {

        int strMod = 0;
        int dexMod = 0;
        int conMod = 0;
        int intMod = 0;
        int wisMod = 0;
        int chaMod = 0;

        int profMod = 0;

        int strSave = 0;
        int dexSave = 0;
        int conSave = 0;
        int intSave = 0;
        int wisSave = 0;
        int chaSave = 0;

        int acrobatics = 0;
        int animal = 0;
        int arcana = 0;
        int athletics = 0;
        int deception = 0;
        int history = 0;
        int insight = 0;
        int intimidation = 0;
        int investigation = 0;
        int medicine = 0;
        int nature = 0;
        int perception = 0;
        int performance = 0;
        int persuasion = 0;
        int religion = 0;
        int sleight = 0;
        int stealth = 0;
        int survival = 0;

        bool isFinesseWep = false;
        bool isRangeWep = false;
        bool isBlank = true;
        Weapon weapon = new Weapon();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int strMod = 0;
            int dexMod = 0;
            int conMod = 0;
            int intMod = 0;
            int wisMod = 0;
            int chaMod = 0;

            int profMod = 0;

            int strSave = 0;
            int dexSave = 0;
            int conSave = 0;
            int intSave = 0;
            int wisSave = 0;
            int chaSave = 0;

            int acrobatics = 0;
            int animal = 0;
            int arcana = 0;
            int athletics = 0;
            int deception = 0;
            int history = 0;
            int insight = 0;
            int intimidation = 0;
            int investigation = 0;
            int medicine = 0;
            int nature = 0;
            int perception = 0;
            int performance = 0;
            int persuasion = 0;
            int religion = 0;
            int sleight = 0;
            int stealth = 0;
            int survival = 0;


            StreamReader reader = new StreamReader(txtLoad.Text + ".txt");

            txtName.Text = reader.ReadLine();

            txtClass.Text = reader.ReadLine();
            txtBackground.Text = reader.ReadLine();
            txtPlayerName.Text = reader.ReadLine();
            txtRace.Text = reader.ReadLine();
            txtAlignment.Text = reader.ReadLine();
            txtXP.Text = reader.ReadLine();

            txtAC.Text = reader.ReadLine();
            txtInitative.Text = reader.ReadLine();
            txtHP.Text = reader.ReadLine();
            txtHitDice.Text = reader.ReadLine();
            txtTempHP.Text = reader.ReadLine();

            txtStr.Text = reader.ReadLine();
            txtDex.Text = reader.ReadLine();
            txtCon.Text = reader.ReadLine();
            txtInt.Text = reader.ReadLine();
            txtWis.Text = reader.ReadLine();
            txtCha.Text = reader.ReadLine();

            txtProf.Text = reader.ReadLine();

            chkInspiration.Checked = Convert.ToBoolean(reader.ReadLine());

            chkStrSave.Checked = Convert.ToBoolean(reader.ReadLine());
            chkDexSave.Checked = Convert.ToBoolean(reader.ReadLine());
            chkConSave.Checked = Convert.ToBoolean(reader.ReadLine());
            chkIntSave.Checked = Convert.ToBoolean(reader.ReadLine());
            chkWisSave.Checked = Convert.ToBoolean(reader.ReadLine());
            chkChaSave.Checked = Convert.ToBoolean(reader.ReadLine());

            chkAcrobatics.Checked = Convert.ToBoolean(reader.ReadLine());
            chkAnimal.Checked = Convert.ToBoolean(reader.ReadLine());
            chkArcana.Checked = Convert.ToBoolean(reader.ReadLine());
            chkAthletics.Checked = Convert.ToBoolean(reader.ReadLine());
            chkDeception.Checked = Convert.ToBoolean(reader.ReadLine());
            chkHistory.Checked = Convert.ToBoolean(reader.ReadLine());
            chkInsight.Checked = Convert.ToBoolean(reader.ReadLine());
            chkIntimidation.Checked = Convert.ToBoolean(reader.ReadLine());
            chkInvestigation.Checked = Convert.ToBoolean(reader.ReadLine());
            chkMedicine.Checked = Convert.ToBoolean(reader.ReadLine());
            chkNature.Checked = Convert.ToBoolean(reader.ReadLine());
            chkPerception.Checked = Convert.ToBoolean(reader.ReadLine());
            chkPerformance.Checked = Convert.ToBoolean(reader.ReadLine());
            chkPersuasion.Checked = Convert.ToBoolean(reader.ReadLine());
            chkReligion.Checked = Convert.ToBoolean(reader.ReadLine());
            chkSleight.Checked = Convert.ToBoolean(reader.ReadLine());
            chkStealth.Checked = Convert.ToBoolean(reader.ReadLine());
            chkSurvival.Checked = Convert.ToBoolean(reader.ReadLine());

            strSaves();
            strSkills();
            dexSaves();
            dexSkills();
            conSaves();
            intSaves();
            intSkills();
            wisSaves();
            wisSkills();
            chaSaves();
            chaSkills();

            txtSave.Text = txtLoad.Text;
            txtLoad.Text = "";

            reader.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(txtSave.Text + ".txt", false);

            writer.WriteLine("{0}", txtName.Text);


            writer.WriteLine("{0}", txtClass.Text);
            writer.WriteLine("{0}", txtBackground.Text);
            writer.WriteLine("{0}", txtPlayerName.Text);
            writer.WriteLine("{0}", txtRace.Text);
            writer.WriteLine("{0}", txtAlignment.Text);
            writer.WriteLine("{0}", txtXP.Text);

            writer.WriteLine("{0}", txtAC.Text);
            writer.WriteLine("{0}", txtInitative.Text);
            writer.WriteLine("{0}", txtHP.Text);
            writer.WriteLine("{0}", txtHitDice.Text);
            writer.WriteLine("{0}", txtTempHP.Text);

            writer.WriteLine("{0}", txtStr.Text);
            writer.WriteLine("{0}", txtDex.Text);
            writer.WriteLine("{0}", txtCon.Text);
            writer.WriteLine("{0}", txtInt.Text);
            writer.WriteLine("{0}", txtWis.Text);
            writer.WriteLine("{0}", txtCha.Text);

            writer.WriteLine("{0}", txtProf.Text);

            writer.WriteLine("{0}", chkInspiration.Checked);

            writer.WriteLine("{0}", chkStrSave.Checked);
            writer.WriteLine("{0}", chkDexSave.Checked);
            writer.WriteLine("{0}", chkConSave.Checked);
            writer.WriteLine("{0}", chkIntSave.Checked);
            writer.WriteLine("{0}", chkWisSave.Checked);
            writer.WriteLine("{0}", chkChaSave.Checked);

            writer.WriteLine("{0}", chkAcrobatics.Checked);
            writer.WriteLine("{0}", chkAnimal.Checked);
            writer.WriteLine("{0}", chkArcana.Checked);
            writer.WriteLine("{0}", chkAthletics.Checked);
            writer.WriteLine("{0}", chkDeception.Checked);
            writer.WriteLine("{0}", chkHistory.Checked);
            writer.WriteLine("{0}", chkInsight.Checked);
            writer.WriteLine("{0}", chkIntimidation.Checked);
            writer.WriteLine("{0}", chkInvestigation.Checked);
            writer.WriteLine("{0}", chkMedicine.Checked);
            writer.WriteLine("{0}", chkNature.Checked);
            writer.WriteLine("{0}", chkPerception.Checked);
            writer.WriteLine("{0}", chkPerformance.Checked);
            writer.WriteLine("{0}", chkPersuasion.Checked);
            writer.WriteLine("{0}", chkReligion.Checked);
            writer.WriteLine("{0}", chkSleight.Checked);
            writer.WriteLine("{0}", chkStealth.Checked);
            writer.WriteLine("{0}", chkSurvival.Checked);

            writer.Close();

            MessageBox.Show(String.Format("Character sheet sucessfully saved to file name \"{0}\"", txtSave.Text), "Sheet Saved", MessageBoxButtons.OK);
            txtSave.Text = "";

        }

        private void txtStr_TextChanged(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtStr.Text, out i);
            switch (i)
            {
                case 1:
                    strMod = -5;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 2:
                case 3:
                    strMod = -4;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 4:
                case 5:
                    strMod = -3;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 6:
                case 7:
                    strMod = -2;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 8:
                case 9:
                    strMod = -1;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 10:
                case 11:
                    strMod = 0;
                    txtStrMod.Text = Convert.ToString(strMod);
                    break;
                case 12:
                case 13:
                    strMod = +1;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 14:
                case 15:
                    strMod = +2;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 16:
                case 17:
                    strMod = +3;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 18:
                case 19:
                    strMod = +4;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 20:
                case 21:
                    strMod = +5;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 22:
                case 23:
                    strMod = +6;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 24:
                case 25:
                    strMod = +7;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 26:
                case 27:
                    strMod = +8;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 28:
                case 29:
                    strMod = +9;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                case 30:
                    strMod = +10;
                    txtStrMod.Text = "+" + Convert.ToString(strMod);
                    break;
                default:
                    txtStrMod.Text = "";
                    break;
            }

            strSaves();
            strSkills();

        }

        private void txtDex_TextChanged_1(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtDex.Text, out i);
            switch (i)
            {
                case 1:
                    dexMod = -5;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 2:
                case 3:
                    dexMod = -4;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 4:
                case 5:
                    dexMod = -3;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 6:
                case 7:
                    dexMod = -2;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 8:
                case 9:
                    dexMod = -1;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 10:
                case 11:
                    dexMod = 0;
                    txtDexMod.Text = Convert.ToString(dexMod);
                    break;
                case 12:
                case 13:
                    dexMod = +1;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 14:
                case 15:
                    dexMod = +2;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 16:
                case 17:
                    dexMod = +3;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 18:
                case 19:
                    dexMod = +4;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 20:
                case 21:
                    dexMod = +5;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 22:
                case 23:
                    dexMod = +6;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 24:
                case 25:
                    dexMod = +7;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 26:
                case 27:
                    dexMod = +8;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 28:
                case 29:
                    dexMod = +9;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                case 30:
                    dexMod = +10;
                    txtDexMod.Text = "+" + Convert.ToString(dexMod);
                    break;
                default:
                    txtDexMod.Text = "";
                    break;
            }

            dexSaves();
            dexSkills();

        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtCon.Text, out i);
            switch (i)
            {
                case 1:
                    conMod = -5;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 2:
                case 3:
                    conMod = -4;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 4:
                case 5:
                    conMod = -3;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 6:
                case 7:
                    conMod = -2;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 8:
                case 9:
                    conMod = -1;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 10:
                case 11:
                    conMod = 0;
                    txtConMod.Text = Convert.ToString(conMod);
                    break;
                case 12:
                case 13:
                    conMod = +1;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 14:
                case 15:
                    conMod = +2;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 16:
                case 17:
                    conMod = +3;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 18:
                case 19:
                    conMod = +4;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 20:
                case 21:
                    conMod = +5;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 22:
                case 23:
                    conMod = +6;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 24:
                case 25:
                    conMod = +7;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 26:
                case 27:
                    conMod = +8;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 28:
                case 29:
                    conMod = +9;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                case 30:
                    conMod = +10;
                    txtConMod.Text = "+" + Convert.ToString(conMod);
                    break;
                default:
                    txtConMod.Text = "";
                    break;
            }

            conSaves();

        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtInt.Text, out i);
            switch (i)
            {
                case 1:
                    intMod = -5;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 2:
                case 3:
                    intMod = -4;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 4:
                case 5:
                    intMod = -3;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 6:
                case 7:
                    intMod = -2;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 8:
                case 9:
                    intMod = -1;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 10:
                case 11:
                    intMod = 0;
                    txtIntMod.Text = Convert.ToString(intMod);
                    break;
                case 12:
                case 13:
                    intMod = +1;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 14:
                case 15:
                    intMod = +2;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 16:
                case 17:
                    intMod = +3;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 18:
                case 19:
                    intMod = +4;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 20:
                case 21:
                    intMod = +5;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 22:
                case 23:
                    intMod = +6;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 24:
                case 25:
                    intMod = +7;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 26:
                case 27:
                    intMod = +8;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 28:
                case 29:
                    intMod = +9;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                case 30:
                    intMod = +10;
                    txtIntMod.Text = "+" + Convert.ToString(intMod);
                    break;
                default:
                    txtIntMod.Text = "";
                    break;
            }

            intSaves();
            intSkills();

        }

        private void txtWis_TextChanged(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtWis.Text, out i);
            switch (i)
            {
                case 1:
                    wisMod = -5;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 2:
                case 3:
                    wisMod = -4;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 4:
                case 5:
                    wisMod = -3;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 6:
                case 7:
                    wisMod = -2;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 8:
                case 9:
                    wisMod = -1;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 10:
                case 11:
                    wisMod = 0;
                    txtWisMod.Text = Convert.ToString(wisMod);
                    break;
                case 12:
                case 13:
                    wisMod = +1;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 14:
                case 15:
                    wisMod = +2;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 16:
                case 17:
                    wisMod = +3;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 18:
                case 19:
                    wisMod = +4;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 20:
                case 21:
                    wisMod = +5;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 22:
                case 23:
                    wisMod = +6;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 24:
                case 25:
                    wisMod = +7;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 26:
                case 27:
                    wisMod = +8;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 28:
                case 29:
                    wisMod = +9;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                case 30:
                    wisMod = +10;
                    txtWisMod.Text = "+" + Convert.ToString(wisMod);
                    break;
                default:
                    txtWisMod.Text = "";
                    break;
            }

            wisSaves();
            wisSkills();

        }

        private void txtCha_TextChanged(object sender, EventArgs e)
        {

            //Setting the modifier

            int i = 0;
            int.TryParse(txtCha.Text, out i);
            switch (i)
            {
                case 1:
                    chaMod = -5;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 2:
                case 3:
                    chaMod = -4;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 4:
                case 5:
                    chaMod = -3;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 6:
                case 7:
                    chaMod = -2;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 8:
                case 9:
                    chaMod = -1;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 10:
                case 11:
                    chaMod = 0;
                    txtChaMod.Text = Convert.ToString(chaMod);
                    break;
                case 12:
                case 13:
                    chaMod = +1;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 14:
                case 15:
                    chaMod = +2;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 16:
                case 17:
                    chaMod = +3;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 18:
                case 19:
                    chaMod = +4;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 20:
                case 21:
                    chaMod = +5;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 22:
                case 23:
                    chaMod = +6;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 24:
                case 25:
                    chaMod = +7;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 26:
                case 27:
                    chaMod = +8;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 28:
                case 29:
                    chaMod = +9;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                case 30:
                    chaMod = +10;
                    txtChaMod.Text = "+" + Convert.ToString(chaMod);
                    break;
                default:
                    txtChaMod.Text = "";
                    break;
            }

            chaSaves();
            chaSkills();
        }

        private void txtProf_TextChanged(object sender, EventArgs e)
        {
            strSaves();
            strSkills();

            dexSaves();
            dexSkills();

            conSaves();

            intSaves();
            intSkills();


            wisSaves();
            wisSkills();

            chaSaves();
            chaSkills();

        }


        private void strSaves()
        {
            strSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkStrSave.Checked)
            {
                strSave = strMod + profMod;
            }
            else
            {
                strSave = strMod;
            }


            if (strSave > 0)
            {
                txtStrSave.Text = "+" + Convert.ToString(strSave);
            }
            else
            {
                txtStrSave.Text = Convert.ToString(strSave);
            }
        }

        private void strSkills()
        {
            athletics = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkAthletics.Checked)
            {
                athletics = strMod + profMod;
            }
            else
            {
                athletics = strMod;
            }

            if (athletics > 0)
            {
                txtAthletics.Text = "+" + Convert.ToString(athletics);
            }
            else
            {
                txtAthletics.Text = Convert.ToString(athletics);
            }
        }


        private void dexSaves()
        {
            dexSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkDexSave.Checked)
            {
                dexSave = dexMod + profMod;
            }
            else
            {
                dexSave = dexMod;
            }


            if (dexSave > 0)
            {
                txtDexSave.Text = "+" + Convert.ToString(dexSave);
            }
            else
            {
                txtDexSave.Text = Convert.ToString(dexSave);
            }
        }

        private void dexSkills()
        {
            acrobatics = 0;
            sleight = 0;
            stealth = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkAcrobatics.Checked)
            {
                acrobatics = dexMod + profMod;
            }
            else
            {
                acrobatics = dexMod;
            }

            if (acrobatics > 0)
            {
                txtAcrobatics.Text = "+" + Convert.ToString(acrobatics);
            }
            else
            {
                txtAcrobatics.Text = Convert.ToString(acrobatics);
            }

            //-------------------------------------------------------------------\\

            if (chkSleight.Checked)
            {
                sleight = dexMod + profMod;
            }
            else
            {
                sleight = dexMod;
            }

            if (sleight > 0)
            {
                txtSleight.Text = "+" + Convert.ToString(sleight);
            }
            else
            {
                txtSleight.Text = Convert.ToString(sleight);
            }

            //-------------------------------------------------------------------\\

            if (chkStealth.Checked)
            {
                stealth = dexMod + profMod;
            }
            else
            {
                stealth = dexMod;
            }

            if (stealth > 0)
            {
                txtStealth.Text = "+" + Convert.ToString(stealth);
            }
            else
            {
                txtStealth.Text = Convert.ToString(stealth);
            }

        }

        private void conSaves()
        {
            conSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkConSave.Checked)
            {
                conSave = conMod + profMod;
            }
            else
            {
                conSave = conMod;
            }


            if (conSave > 0)
            {
                txtConSave.Text = "+" + Convert.ToString(conSave);
            }
            else
            {
                txtConSave.Text = Convert.ToString(conSave);
            }
        }

        private void intSaves()
        {
            intSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkIntSave.Checked)
            {
                intSave = intMod + profMod;
            }
            else
            {
                intSave = intMod;
            }


            if (intSave > 0)
            {
                txtIntSave.Text = "+" + Convert.ToString(intSave);
            }
            else
            {
                txtIntSave.Text = Convert.ToString(intSave);
            }
        }

        private void intSkills()
        {
            arcana = 0;
            history = 0;
            investigation = 0;
            nature = 0;
            religion = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkArcana.Checked)
            {
                arcana = intMod + profMod;
            }
            else
            {
                arcana = intMod;
            }

            if (arcana > 0)
            {
                txtArcana.Text = "+" + Convert.ToString(arcana);
            }
            else
            {
                txtArcana.Text = Convert.ToString(arcana);
            }

            //-------------------------------------------------------------------\\

            if (chkHistory.Checked)
            {
                history = intMod + profMod;
            }
            else
            {
                history = intMod;
            }

            if (history > 0)
            {
                txtHistory.Text = "+" + Convert.ToString(history);
            }
            else
            {
                txtHistory.Text = Convert.ToString(history);
            }

            //-------------------------------------------------------------------\\

            if (chkInvestigation.Checked)
            {
                investigation = intMod + profMod;
            }
            else
            {
                investigation = intMod;
            }

            if (investigation > 0)
            {
                txtInvestigation.Text = "+" + Convert.ToString(investigation);
            }
            else
            {
                txtInvestigation.Text = Convert.ToString(investigation);
            }

            //-------------------------------------------------------------------\\

            if (chkNature.Checked)
            {
                nature = intMod + profMod;
            }
            else
            {
                nature = intMod;
            }

            if (nature > 0)
            {
                txtNature.Text = "+" + Convert.ToString(nature);
            }
            else
            {
                txtNature.Text = Convert.ToString(nature);
            }

            //-------------------------------------------------------------------\\

            if (chkReligion.Checked)
            {
                religion = intMod + profMod;
            }
            else
            {
                religion = intMod;
            }

            if (religion > 0)
            {
                txtReligion.Text = "+" + Convert.ToString(religion);
            }
            else
            {
                txtReligion.Text = Convert.ToString(religion);
            }
        }

        private void wisSaves()
        {
            wisSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkWisSave.Checked)
            {
                wisSave = wisMod + profMod;
            }
            else
            {
                wisSave = wisMod;
            }


            if (wisSave > 0)
            {
                txtWisSave.Text = "+" + Convert.ToString(wisSave);
            }
            else
            {
                txtWisSave.Text = Convert.ToString(wisSave);
            }
        }

        private void wisSkills()
        {
            animal = 0;
            insight = 0;
            medicine = 0;
            perception = 0;
            survival = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkAnimal.Checked)
            {
                animal = wisMod + profMod;
            }
            else
            {
                animal = wisMod;
            }

            if (animal > 0)
            {
                txtAnimal.Text = "+" + Convert.ToString(animal);
            }
            else
            {
                txtAnimal.Text = Convert.ToString(animal);
            }

            //-------------------------------------------------------------------\\

            if (chkInsight.Checked)
            {
                insight = wisMod + profMod;
            }
            else
            {
                insight = wisMod;
            }

            if (insight > 0)
            {
                txtInsight.Text = "+" + Convert.ToString(insight);
            }
            else
            {
                txtInsight.Text = Convert.ToString(insight);
            }

            //-------------------------------------------------------------------\\

            if (chkMedicine.Checked)
            {
                medicine = wisMod + profMod;
            }
            else
            {
                medicine = wisMod;
            }

            if (medicine > 0)
            {
                txtMedicine.Text = "+" + Convert.ToString(medicine);
            }
            else
            {
                txtMedicine.Text = Convert.ToString(medicine);
            }

            //-------------------------------------------------------------------\\

            if (chkPerception.Checked)
            {
                perception = wisMod + profMod;
            }
            else
            {
                perception = wisMod;
            }

            if (perception > 0)
            {
                txtPerception.Text = "+" + Convert.ToString(perception);
            }
            else
            {
                txtPerception.Text = Convert.ToString(perception);
            }

            //-------------------------------------------------------------------\\

            if (chkSurvival.Checked)
            {
                survival = wisMod + profMod;
            }
            else
            {
                survival = wisMod;
            }

            if (insight > 0)
            {
                txtSurvival.Text = "+" + Convert.ToString(survival);
            }
            else
            {
                txtSurvival.Text = Convert.ToString(survival);
            }

        }

        private void chaSaves()
        {
            chaSave = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkChaSave.Checked)
            {
                chaSave = chaMod + profMod;
            }
            else
            {
                chaSave = chaMod;
            }


            if (chaSave > 0)
            {
                txtChaSave.Text = "+" + Convert.ToString(chaSave);
            }
            else
            {
                txtChaSave.Text = Convert.ToString(chaSave);
            }
        }
        private void chaSkills()
        {
            deception = 0;
            intimidation = 0;
            performance = 0;
            persuasion = 0;
            int.TryParse(txtProf.Text, out profMod);

            if (chkDeception.Checked)
            {
                deception = chaMod + profMod;
            }
            else
            {
                deception = chaMod;
            }

            if (deception > 0)
            {
                txtDeception.Text = "+" + Convert.ToString(deception);
            }
            else
            {
                txtDeception.Text = Convert.ToString(deception);
            }

            //-------------------------------------------------------------------\\

            if (chkIntimidation.Checked)
            {
                intimidation = chaMod + profMod;
            }
            else
            {
                intimidation = chaMod;
            }

            if (intimidation > 0)
            {
                txtIntimidation.Text = "+" + Convert.ToString(intimidation);
            }
            else
            {
                txtIntimidation.Text = Convert.ToString(intimidation);
            }

            //-------------------------------------------------------------------\\

            if (chkPerformance.Checked)
            {
                performance = chaMod + profMod;
            }
            else
            {
                performance = chaMod;
            }

            if (performance > 0)
            {
                txtPerformance.Text = "+" + Convert.ToString(performance);
            }
            else
            {
                txtPerformance.Text = Convert.ToString(performance);
            }

            //-------------------------------------------------------------------\\

            if (chkPersuasion.Checked)
            {
                persuasion = chaMod + profMod;
            }
            else
            {
                persuasion = chaMod;
            }

            if (persuasion > 0)
            {
                txtPersuasion.Text = "+" + Convert.ToString(persuasion);
            }
            else
            {
                txtPersuasion.Text = Convert.ToString(persuasion);
            }
        }

        private void chkStrSave_CheckedChanged(object sender, EventArgs e)
        {
            strSaves();
        }

        private void chkDexSave_CheckedChanged(object sender, EventArgs e)
        {
            dexSaves();
        }

        private void chkConSave_CheckedChanged(object sender, EventArgs e)
        {
            conSaves();
        }

        private void chkIntSave_CheckedChanged(object sender, EventArgs e)
        {
            intSaves();
        }

        private void chkWisSave_CheckedChanged(object sender, EventArgs e)
        {
            wisSaves();
        }

        private void chkChaSave_CheckedChanged(object sender, EventArgs e)
        {
            chaSaves();
        }

        private void chkAcrobatics_CheckedChanged(object sender, EventArgs e)
        {
            dexSkills();
        }

        private void chkAnimal_CheckedChanged(object sender, EventArgs e)
        {
            wisSkills();
        }

        private void chkArcana_CheckedChanged(object sender, EventArgs e)
        {
            intSkills();
        }

        private void chkAthletics_CheckedChanged(object sender, EventArgs e)
        {
            strSkills();
        }

        private void chkDeception_CheckedChanged(object sender, EventArgs e)
        {
            chaSkills();
        }

        private void chkHistory_CheckedChanged(object sender, EventArgs e)
        {
            intSkills();
        }

        private void chkInsight_CheckedChanged(object sender, EventArgs e)
        {
            wisSkills();
        }

        private void chkIntimidation_CheckedChanged(object sender, EventArgs e)
        {
            chaSkills();
        }

        private void chkInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            intSkills();
        }

        private void chkMedicine_CheckedChanged(object sender, EventArgs e)
        {
            wisSkills();
        }

        private void chkNature_CheckedChanged(object sender, EventArgs e)
        {
            intSkills();
        }

        private void chkPerception_CheckedChanged(object sender, EventArgs e)
        {
            wisSkills();
        }

        private void chkPerformance_CheckedChanged(object sender, EventArgs e)
        {
            chaSkills();
        }

        private void chkPersuasion_CheckedChanged(object sender, EventArgs e)
        {
            chaSkills();
        }

        private void chkReligion_CheckedChanged(object sender, EventArgs e)
        {
            intSkills();
        }

        private void chkSleight_CheckedChanged(object sender, EventArgs e)
        {
            dexSkills();
        }

        private void chkStealth_CheckedChanged(object sender, EventArgs e)
        {
            dexSkills();
        }

        private void chkSurvival_CheckedChanged(object sender, EventArgs e)
        {
            wisSkills();
        }

        private void weaponList_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (weaponList.SelectedIndex)
            {
                case 0:
                    txtAtkBonus.Text = "";
                    txtDamage.Text = "";
                    isFinesseWep = false;
                    isRangeWep = false;
                    weapon.diceNum = 0;
                    isBlank = true;
                    break;

                case 1:
                    basicWeaponCalc("1d4");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 2:
                    finesseWeaponCalc("1d4");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 3:
                    basicWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 4:
                    basicWeaponCalc("1d6");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 5:
                    basicWeaponCalc("1d6");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 6:
                    basicWeaponCalc("1d4");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 7:
                    basicWeaponCalc("1d6");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 8:
                    versatileWeaponCalc("1d6", "1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 9:
                    basicWeaponCalc("1d4");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 10:
                    versatileWeaponCalc("1d6", "1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;

                case 11:
                    rangedWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;
                case 12:
                    finesseWeaponCalc("1d4");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 13:
                    rangedWeaponCalc("1d6");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;
                case 14:
                    rangedWeaponCalc("1d4");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;

                case 15:
                    versatileWeaponCalc("1d8", "1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 16:
                    basicWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 17:
                    basicWeaponCalc("1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 18:
                    basicWeaponCalc("1d12");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 19:
                    basicWeaponCalc("2d6");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 20:
                    basicWeaponCalc("1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 21:
                    basicWeaponCalc("1d12");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 22:
                    versatileWeaponCalc("1d8", "1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 23:
                    basicWeaponCalc("2d6");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 24:
                    basicWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 25:
                    basicWeaponCalc("1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 26:
                    finesseWeaponCalc("1d8");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 27:
                    finesseWeaponCalc("1d6");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 28:
                    finesseWeaponCalc("1d6");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 29:
                    versatileWeaponCalc("1d6", "1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 30:
                    basicWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 31:
                    versatileWeaponCalc("1d8", "1d10");
                    isFinesseWep = false;
                    isRangeWep = false;
                    isBlank = false;
                    break;
                case 32:
                    finesseWeaponCalc("1d4");
                    isFinesseWep = true;
                    isRangeWep = false;
                    isBlank = false;
                    break;

                case 33:
                    int atkBonus = dexMod + profMod;
                    int damageBonus = dexMod;

                    if (atkBonus > 0)
                    {
                        txtAtkBonus.Text = string.Format("+{0}", atkBonus);
                    }
                    else
                    {
                        txtAtkBonus.Text = string.Format("{0}", atkBonus);
                    }


                    if (damageBonus == 0)
                    {
                        txtDamage.Text = string.Format("1");
                    }
                    else
                    {
                        txtDamage.Text = string.Format("{0}", 1+damageBonus);
                    }
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;
                case 34:
                    rangedWeaponCalc("1d6");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;
                case 35:
                    rangedWeaponCalc("1d10");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;
                case 36:
                    rangedWeaponCalc("1d8");
                    isFinesseWep = false;
                    isRangeWep = true;
                    isBlank = false;
                    break;

                default:
                    txtAtkBonus.Text = "";
                    txtDamage.Text = "";
                    isFinesseWep = false;
                    isRangeWep = false;
                    weapon.diceNum = 0;
                    isBlank = true;
                    break;
            }
        }


        private void basicWeaponCalc(string d)
        {
           int atkBonus = strMod + profMod;
           int damageBonus = strMod;

            if (atkBonus > 0)
            {
                txtAtkBonus.Text = string.Format("+{0}", atkBonus);
            }
            else
            {
                txtAtkBonus.Text = string.Format("{0}", atkBonus);
            }


            if (damageBonus == 0)
            {
                txtDamage.Text = string.Format("{0}", d);
            }
            else if (damageBonus > 0)
            {
                txtDamage.Text = string.Format("{0} + {1}", d, damageBonus);
            }
            else
            {
                txtDamage.Text = string.Format("{0} - {1}", d, (damageBonus*-1));
            }

            weapon.diceNum = Convert.ToInt32(d.Remove(0, 2));
        }

        private void versatileWeaponCalc(string d1, string d2)
        {
            int atkBonus = strMod + profMod;
            int damageBonus = strMod;

            if (atkBonus > 0)
            {
                txtAtkBonus.Text = string.Format("+{0}", atkBonus);
            }
            else
            {
                txtAtkBonus.Text = string.Format("{0}", atkBonus);
            }


            if (damageBonus == 0)
            {
                txtDamage.Text = string.Format("{0} / {1}", d1, d2);
            }
            else if (damageBonus > 0)
            {
                txtDamage.Text = string.Format("{0} + {1} / {2} + {1}", d1, damageBonus, d2);
            }
            else
            {
                txtDamage.Text = string.Format("{0} - {1} / {2} - {1}", d1, (-1*damageBonus), d2);
            }

            weapon.diceNum = Convert.ToInt32(d1.Remove(0, 2));
        }


        private void finesseWeaponCalc(string d)
        {
            int atkBonus = strMod + profMod;
            int damageBonus = strMod;

            if (strMod >= dexMod)
            {
                atkBonus = strMod + profMod;
                damageBonus = strMod;
            }
            else
            {
                atkBonus = dexMod + profMod;
                damageBonus = dexMod;
            }

            if (atkBonus > 0)
            {
                txtAtkBonus.Text = string.Format("+{0}", atkBonus);
            }
            else
            {
                txtAtkBonus.Text = string.Format("{0}", atkBonus);
            }


            if (damageBonus == 0)
            {
                txtDamage.Text = string.Format("{0}", d);
            }
            else if (damageBonus > 0)
            {
                txtDamage.Text = string.Format("{0} + {1}", d, damageBonus);
            }
            else
            {
                txtDamage.Text = string.Format("{0} - {1}", d, (-1*damageBonus));
            }

            weapon.diceNum = Convert.ToInt32(d.Remove(0, 2));
        }

        private void rangedWeaponCalc(string d)
        {
            int atkBonus = dexMod + profMod;
            int damageBonus = dexMod;

            if (atkBonus > 0)
            {
                txtAtkBonus.Text = string.Format("+{0}", atkBonus);
            }
            else
            {
                txtAtkBonus.Text = string.Format("{0}", atkBonus);
            }


            if (damageBonus == 0)
            {
                txtDamage.Text = string.Format("{0}", d);
            }
            else if (damageBonus > 0)
            {
                txtDamage.Text = string.Format("{0} + {1}", d, damageBonus);
            }
            else
            {
                txtDamage.Text = string.Format("{0} - {1}", d, (-1*damageBonus));
            }

            weapon.diceNum = Convert.ToInt32(d.Remove(0, 2));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(isFinesseWep)
            {
                if (strMod >= dexMod)
                {
                    weapon.noWeapon = false;
                    weapon.bonDam = strMod;
                    weapon.attackBon = strMod + profMod;
                }
                else
                {
                    weapon.noWeapon = false;
                    weapon.bonDam = dexMod;
                    weapon.attackBon = dexMod + profMod;

                }
            }
            else if(isRangeWep)
            {
                weapon.noWeapon = false;
                weapon.bonDam = dexMod;
                weapon.attackBon = dexMod + profMod;
            }
            else if(isBlank)
            {
                weapon.noWeapon = true;
                weapon.bonDam = strMod;
                weapon.attackBon = strMod + profMod;
            }
            else
            {
                weapon.noWeapon = false;
                weapon.bonDam = strMod;
                weapon.attackBon = strMod + profMod;
            }

            weapon.doAttack();
            
        }
    }
}
