﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMæglerneAS
{
    public class BoligBLL : IComparable
    {
        public int BoligID { get; private set; }
        public string Vej { get; private set; }
        public int Postnummer { get; private set; }
        public string Type { get; private set; }
        public int Værelser { get; private set; }
        public int Etager { get; private set; }
        public int Kvadratmeter { get; private set; }
        public int Udbudspris { get; private set; }
        public bool Have { get; private set; }
        public DateTime Bygningsår { get; private set; }
        public DateTime RenoveringsÅr { get; private set; }

        //BoligBLL constructors
        public BoligBLL(int boligid, string vej, int postnummer, string type, int værelser, int etager, int kvadratmeter, bool have, DateTime bygningsår, DateTime renoveringsår)
        {
            this.BoligID = boligid;
            this.Vej = vej;
            this.Postnummer = postnummer;
            this.Type = type;
            this.Værelser = værelser;
            this.Etager = etager;
            this.Kvadratmeter = kvadratmeter;
            this.Udbudspris = CalculateUdbudsPris();
            this.Have = have;
            this.Bygningsår = bygningsår;
            this.RenoveringsÅr = renoveringsår;
        }

        public BoligBLL(int boligid, string vej, int postnummer, string type, int værelser, int etager, int kvadratmeter, int udbudspris, bool have, DateTime bygningsår, DateTime renoveringsår)
        {
            this.BoligID = boligid;
            this.Vej = vej;
            this.Postnummer = postnummer;
            this.Type = type;
            this.Værelser = værelser;
            this.Etager = etager;
            this.Kvadratmeter = kvadratmeter;
            this.Udbudspris = udbudspris;
            this.Have = have;
            this.Bygningsår = bygningsår;
            this.RenoveringsÅr = renoveringsår;
        }

        public BoligBLL(int boligid, string vej, int postnummer)
        {
            this.BoligID = boligid;
            this.Vej = vej;
            this.Postnummer = postnummer;
        }

        public BoligBLL(int boligid)
        {
            this.BoligID = boligid;
        }

        public BoligBLL() { }

        //this method returns object in a specific format
        public override string ToString()
        {
            return ToString("A");
        }

        //this method is a helper method to ToString method, to choose the format in which the object will be shown
        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "A";
            switch (fmt.ToUpperInvariant())
            {
                case "A":
                    return string.Format($"{BoligID} - {Vej} - {Postnummer}");
                case "B":
                    return string.Format($"ID: {BoligID} \t\t{Vej, 20} {Postnummer, 10} \t{Udbudspris, 20}- kr");
                default:
                    return string.Format($"ID: {BoligID} \t, Adresse: {Vej} - {Postnummer}, \n" +
                        $"{Type}, værelser: {Værelser}, etager: {Etager}, kvm: {Kvadratmeter}, {HasGarden(this.Have)}, \n" +
                        $"pris: {Udbudspris}, bygget i: {Bygningsår}{IsRenoveret(this.Bygningsår, this.RenoveringsÅr)}");
            }
        }

        //helper methods to ToString format
        private string HasGarden(bool have)
        {
            if (have)
                return $"med have";
            else
                return $"uden have";
        }

        private string IsRenoveret(DateTime bygningsår, DateTime renoveringsår)
        {
            if (DateTime.Compare(bygningsår, renoveringsår) == 0)
                return ", ikke blevet renoveret siden byggelsen";
            else
                return $", renoveret i {renoveringsår}";
        }

        //this method calculates the Udbudspris
        public int CalculateUdbudsPris()
        {
            int pris = 0;

            //divides the price of kvm by zone (postnummer)
            if (this.Postnummer > 999 && this.Postnummer < 3000) //KBH
                pris += this.Kvadratmeter * 40000;
            else if (this.Postnummer >= 3000 && this.Postnummer < 5400  //SJÆLLAND + ODENSE
                || this.Postnummer >= 8000 && this.Postnummer < 8800 //AARHUS (OG ØSTJYLLAND)
                || this.Postnummer >= 9000 && this.Postnummer < 9400) //AALBORG
                pris += this.Kvadratmeter * 20000;
            else if (this.Postnummer >= 5400 && this.Postnummer < 6000) //FYN 
                pris += this.Kvadratmeter * 15000;
            else if (this.Postnummer >= 6000 && this.Postnummer < 8000) //SØNDERJYLLAND + MIDTJYLLAND
                pris += this.Kvadratmeter * 8000;
            else if (this.Kvadratmeter >= 8800 && this.Postnummer < 9000) //RANDERS OG LIGNEDE
                pris += this.Kvadratmeter * 5000;
            else if (this.Kvadratmeter >= 9400 && this.Postnummer < 9999) //SKAGEN OG SOMMERHUSE PÅ NORDJYLLAND
                pris += this.Kvadratmeter * 20000;
            else
                pris += this.Kvadratmeter * 5000;

            //adds percent of the price depending of the house type
            if (this.Type == "Lejlighed")
                pris += pris / 100 * 1;
            else if (this.Type == "Villa")
                pris += pris / 100 * 3;
            else if (this.Type == "Rækkehus")
                pris += pris / 100 * 2;

            //every room costs 500 more
            pris += this.Værelser * 500;

            //every etage costs 1000 more
            pris += this.Etager * 1000;

            //if the house has a garden, it costs 5000 more
            if (this.Have)
                pris += 5000;

            DateTime date1 = this.Bygningsår;
            DateTime date2 = new DateTime(1950, 1, 1, 0, 0, 0);
            int result = DateTime.Compare(date1, date2);

            if (result < 0) //if the house is built EARLIER THAN 1950
                pris -= 30000; //it costs 30000 less
            if (result >= 0) //Lif the house is built AFTER THAN 1950
                pris += 15000; //it costs 15000 more

            date1 = this.RenoveringsÅr;
            date2 = new DateTime(2010, 1, 1, 0, 0, 0);
            result = DateTime.Compare(date1, date2);

            if (result >= 0) //if it has been renewed, it will cost 1000 more
                pris += 1000;

            return pris;
        }

        //implementation of CompareTo
        public int CompareTo(object other)
        {
            if (other == null)
                return 1;
            else if (!(other is BoligBLL))
                throw new ArgumentException("Object is not a Bolig");

            BoligBLL bolig = (BoligBLL)other;

            if (string.Compare(this.Vej, bolig.Vej) > 0)
                return 1;
            else if (string.Compare(this.Vej, bolig.Vej) < 0)
                return -1;
            else if (this.Vej.Equals(bolig.Vej))
            {
                if (this.Udbudspris > bolig.Udbudspris)
                    return 1;
                else if (this.Udbudspris < bolig.Udbudspris)
                    return -1;
                else
                    return 0;
            }
            else
                return 0;
        }

        public static bool BoligExists(int boligid)
        {
            return BoligDAL.BoligExists(boligid);
        }

        #region CRUD Bolig
        public void OpretBolig(BoligBLL bolig)
        {
            BoligDAL boligDAL = new BoligDAL();
            boligDAL.OpretBolig(bolig);
        }

        public static BoligBLL HentBoligViaID(BoligBLL boligToFind)
        {
            return BoligDAL.HentBoligViaID(boligToFind);
        }

        public static BoligBLL HentBolig(BoligBLL boligToFind)
        {
            return BoligDAL.HentBolig(boligToFind);
        }

        public void OpdaterBolig(BoligBLL bolig)
        {
            BoligDAL boligDAL = new BoligDAL();
            boligDAL.OpdaterBolig(bolig);
        }

        public void SletBolig(BoligBLL bolig)
        {
            BoligDAL boligDAL = new BoligDAL();
            boligDAL.SletBolig(bolig);
        }
        #endregion
    }
}