﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SælgerUI : Form
    {
        SælgerBLL sælger;

        public SælgerUI()
        {
            InitializeComponent();
        }

        #region Opret Sælger
        private void btn_OpretSælger_Click(object sender, EventArgs e)
        {
            sælger = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());

            //Kalder metoden: OpretSælger
            try
            {
                if (TjekSælgerVærdierOpret() && !SælgerBLL.SælgerCPRExists(SælgerCPR(), SælgerID()))
                {
                    sælger.OpretSælger(sælger);

                    DisableAll();

                    SælgerBLL matchingsælger = SælgerBLL.HentSælger(sælger);
                    
                    if (matchingsælger != null)
                        sælgerID_txt.Text = matchingsælger.SælgerID.ToString();
                }
                else
                    MessageBox.Show("Sælgeren findes allerede i databasen! Prøv venligst med en anden CPR nummer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview
            SælgerUI_Load(sender, e);

        }

        private void btn_SælgerClear_Click(object sender, EventArgs e)
        {
            ClearAll();

            EnableAll();

            sælgerID_txt.Enabled = false;
        }
        #endregion

        #region Hent Sælger / Opdater Sælger
        private void btn_HentSælger_Click(object sender, EventArgs e) //MIGHT WORK?
        {
            sælger = new SælgerBLL(SælgerID());

            try
            {
                if (TjekSælgeridVærdi() && SælgerBLL.SælgerExists(SælgerID()))
                {
                    SælgerBLL matchingeSælger = SælgerBLL.HentSælgerViaID(sælger);

                    if (matchingeSælger != null)
                    {
                        sælgerCPR_txt.Text = matchingeSælger.CPR.ToString();
                        sælgerTelefon_txt.Text = matchingeSælger.Telefon.ToString();
                        sælgerEmail_txt.Text = matchingeSælger.Email.ToString();
                        sælgerFornavn_txt.Text = matchingeSælger.Fnavn.ToString();
                        sælgerEfternavn_txt.Text = matchingeSælger.Enavn.ToString();
                        sælgerVej_txt.Text = matchingeSælger.Vej.ToString();
                        sælgerPostnummer_txt.Text = matchingeSælger.Postnummer.ToString();
                    }
                }
                else
                    MessageBox.Show("Der findes ikke nogen sælger i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sælgerID_txt.Enabled = false;
        }

        private void btn_SælgerRediger_Click(object sender, EventArgs e)
        {
            EnableAll();

            sælgerID_txt.Enabled = false;
        }

        private void btn_OpdaterSælger_Click(object sender, EventArgs e) //NOT WORKING YET
        {
            sælger = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());

            try
            {
                if (!SælgerBLL.SælgerExists(SælgerID()))
                    MessageBox.Show("Der findes ikke nogen sælger i database med dette ID. Prøv venligst med en anden ID.");
                //else if (SælgerBLL.SælgerCPRExists(SælgerCPR(), SælgerID()))
                //    MessageBox.Show("Sælger kan ikke opdateres med dette CPR, da den findes allerede i database");
                else if (!TjekSælgerVærdierOpdater())
                    MessageBox.Show("Nogle af de input virker forkerte... Vil du tjekke en gang til?");
                else
                {
                    sælger.OpdaterSælger(sælger);

                    DisableAll();

                    btn_HentSælger_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the database, here is the log:\n\n" + ex.Message);
            }

            SælgerUI_Load(sender, e);
        }

        private void btn_SælgerClearHent_Click(object sender, EventArgs e)
        {
            ClearAll();

            DisableAll();

            sælgerID_txt.Enabled = true;
        }
        #endregion

        #region Slet Sælger
        private void btn_SletSælger_Click(object sender, EventArgs e)
        {
            sælger = new SælgerBLL(SælgerID());

            try
            {
                if (TjekSælgeridVærdi() && SælgerBLL.SælgerExists(SælgerID()))
                {
                    sælger.SletSælger(sælger);
                }
                else
                    MessageBox.Show("Der findes ikke nogen sælger i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SælgerUI_Load(sender, e);

            ClearAll();

            DisableAll();

            sælgerID_txt.Enabled = true;
        }
        #endregion

        #region Convert Textboxes
        private int SælgerID()
        {
            int.TryParse(sælgerID_txt.Text, out int sælgerid);
            return sælgerid;
        }

        private long SælgerCPR()
        {
            Int64.TryParse(sælgerCPR_txt.Text, out long sælgercpr);
            return sælgercpr;
        }

        private string SælgerFornavn()
        {
            return sælgerFornavn_txt.Text;
        }

        private string SælgerEfternavn()
        {
            return sælgerEfternavn_txt.Text;
        }

        private int SælgerTelefon()
        {
            int.TryParse(sælgerTelefon_txt.Text, out int sælgertelefon);
            return sælgertelefon;
        }

        private string SælgerEmail()
        {
            return sælgerEmail_txt.Text;
        }

        private string SælgerVej()
        {
            return sælgerVej_txt.Text;
        }

        private int SælgerPostnummer()
        {
            int.TryParse(sælgerPostnummer_txt.Text, out int sælgerpostnummer);
            return sælgerpostnummer;
        }
        #endregion

        #region Tjek Tekstboks Værdier
        private bool TjekSælgeridVærdi()
        {
            if(!int.TryParse(sælgerID_txt.Text, out int i))
            {
                MessageBox.Show("Ugyldigt ID");
                return false;
            }

            return true;
        }

        private bool TjekSælgeCPRdVærdi()
        {
            if (!Int64.TryParse(sælgerCPR_txt.Text, out long i))
            {
                MessageBox.Show("Ugyldigt CPR");
                return false;
            }

            return true;
        }

        private bool TjekSælgerTelefonVærdi()
        {
            if (!int.TryParse(sælgerTelefon_txt.Text, out int i))
            {
                MessageBox.Show("Ugyldigt telefon nummer");

                return false;
            }

            return true;
        }

        public bool TjekSælgerEmailVærdi()
        {
            if (Regex.IsMatch(sælgerEmail_txt.Text, ("^[a-zA-z æøåÆØÅ@.-]+$")))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ugyldig Email");
                return false;
            }
        }

        public bool TjekSælgerFnavnVærdi()
        {
            if (Regex.IsMatch(sælgerFornavn_txt.Text, ("^[a-zA-z æøåÆØÅ-]+$")))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ugyldigt fornavn");
                return false;
            }
        }

        public bool TjekSælgerEnavnVærdi()
        {
            if (Regex.IsMatch(sælgerEfternavn_txt.Text, ("^[a-zA-z æøåÆØÅ-]+$")))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ugyldigt efternavn");
                return false;
            }
        }

        public bool TjekSælgerVejVærdi()
        {
            if (Regex.IsMatch(sælgerVej_txt.Text, ("^[a-zA-z æøåÆØÅ 0-9-]+$")))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ugyldig vej");
                return false;
            }
        }

        private bool TjekSælgerPostnummerVærdi()
        {
            if (sælgerPostnummer_txt.Text.Length != 4 || !int.TryParse(sælgerPostnummer_txt.Text, out int i))
            {
                MessageBox.Show("Ugyldigt postnummer");

                return false;
            }

            return true;
        }

        //Tjekker alle værdier i det tekstbokse som bruges til at oprette en sælger
        public bool TjekSælgerVærdierOpret()
        {
            if (TjekSælgeCPRdVærdi() && TjekSælgerTelefonVærdi() && TjekSælgerEmailVærdi() && TjekSælgerFnavnVærdi() && TjekSælgerEnavnVærdi() && TjekSælgerVejVærdi() && TjekSælgerPostnummerVærdi())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TjekSælgerVærdierOpdater()
        {
            if (TjekSælgeridVærdi() && TjekSælgeCPRdVærdi() && TjekSælgerTelefonVærdi() &&TjekSælgerEmailVærdi() && TjekSælgerFnavnVærdi() && TjekSælgerEnavnVærdi() && TjekSælgerVejVærdi() && TjekSælgerPostnummerVærdi())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region MENUBAREN
        //SÆLGER MENUBARKNAPPER - I SÆLGER MENU
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent sælger
        {
            MenuBarKnapper.SælgerHentOpdater();
        }

        //private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        //{
        //    MenuBarKnapper.SælgerOpdater();
        //}

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sælger
        {
            MenuBarKnapper.SælgerSlet();
        }

        //EJENDOMSMÆGLER MENUBARKNAPPER - I SÆLGER MENU
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmælger
        {
            MenuBarKnapper.EjendomsmæglerHentOpdater();
        }

        //private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmægler
        //{
        //    MenuBarKnapper.EjendomsmæglerOpdater();
        //}

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //KØBER MENUBARKNAPPER - I SÆLGER MENU
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent køber 
        {
            MenuBarKnapper.KøberRead();
        }

        /*private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater køber
        {
            MenuBarKnapper.KøberUpdate();
        }*/

        private void køber_deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet køber
        {
            MenuBarKnapper.KøberDelete();
        }

        //SAG MENUBARKNAPPER - I SÆLGER MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sag
        {
            MenuBarKnapper.SagHent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sag
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sag
        {
            MenuBarKnapper.SagSlet();
        }

        //ÅBENT HUS MENUBARKNAPPER - I SÆLGER MENU
        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //BOLIG MENUBARKNAPPER - I SÆLGER MENU
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.OpretBolig();
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SletBolig();
        }

        // HANDEL MENUBARKNAPPER - I SÆLGER MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent handel
        {
            MenuBarKnapper.HandelHent();
        }

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        private void udtrækStatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HandelStatistik();
        }

        #endregion

        private void SælgerUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sælgerDataSet.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter.Fill(this.sælgerDataSet.Sælger);

        }
    }
}
