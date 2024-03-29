﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class ÅbentHusDAL : BoligDAL //inherits from BoligDAL (so that the methods can be called with the same name)
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        private ListBox output; //THE BIG ListBox
        private TextBox bogstav1; //THE FIRST LETTER WE FILTER THE ADRESSES WITH
        private TextBox bogstav2; //THE SECOND LETTER WE FILTER THE ADDRESSES WITH

        //ÅbentHusDAL constructor
        public ÅbentHusDAL(ListBox lBox, TextBox t1, TextBox t2) : base(lBox)
        {
            output = lBox;
            bogstav1 = t1;
            bogstav2 = t2;
        }

        private delegate void DisplayDelegateÅbent(List<BoligBLL> boliger);

        protected override void DisplayBolig(List<BoligBLL> boliger)
        {
            //CLEAR OUTPUT EVERY TIME
            //so that we don't have an infinite list
            output.Items.Clear();

            //IF txt1 AND txt2 ARE EMPTY
            if (string.IsNullOrEmpty(bogstav1.Text) && string.IsNullOrEmpty(bogstav2.Text))
            {
                //FOREACH ITEM IN THE LIST
                //ADD ITEM TO OUTPUT
                foreach (BoligBLL bolig in boliger)
                    output.Items.Add(bolig.ToString("B"));
            }
            //IF ONLY txt2 IS EMPTY
            else if (string.IsNullOrEmpty(bogstav2.Text))
            {
                //START IS THE FIRST LETTER OF THE RANGE ADDRESSES ARE FILTERED WITH
                char start = bogstav1.Text.ToUpper()[0];

                foreach (BoligBLL bolig in boliger)
                {
                    //FOREACH ITEM IN THE LIST
                    //IF THE ADDRESS STARTS WITH A LETTER THAT IS BIGGER OR EQUAL THAN START
                    //THEN ADD ITEM TO OUTPUT
                    if (bolig.Vej.ToUpper()[0] >= start)
                        output.Items.Add(bolig.ToString("B"));
                }
            }
            else
            {
                //START IS THE FIRST LETTER OF THE RANGE ADDRESSES ARE FILTERED WITH
                char start = bogstav1.Text.ToUpper()[0];
                //START IS THE LAST LETTER OF THE RANGE ADDRESSES ARE FILTERED WITH
                char end = bogstav2.Text.ToUpper()[0];

                foreach (BoligBLL bolig in boliger)
                {
                    //FOREACH ITEM IN THE LIST
                    //IF THE ADDRESS STARTS WITH A LETTER THAT IS BIGGER OR EQUAL THAN START
                    //AND IF THE ADDRESS STARTS WITH A LETTER THAT IS LESS OR EQUAL THAN END
                    //THEN ADD ITEM TO OUTPUT
                    if (bolig.Vej.ToUpper()[0] >= start && bolig.Vej.ToUpper()[0] <= end)
                        output.Items.Add(bolig.ToString("B"));
                }
            }

            //Lambda implementation

            //List<BoligBLL> sortedBolig = boliger.FindAll(item => Between(item, a, b));

            //Implement Between
            //private bool Between(string s, char a, char b)
            //{
            //    if (s[0] >= a && s[0] <= b)
            //    {
            //        return true;
            //    }

            //    return false;
            //}
        }

        //method to retrieve all BoligID to show in the ComboBox of SagUI
        //returns a List of BoligBLL
        protected override List<BoligBLL> FetchBolig()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<BoligBLL> boliger = new List<BoligBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString()))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * " +
                    "FROM Bolig " +
                    "WHERE BoligID " +
                    "IN (" +
                            "SELECT Sag.BoligID " +
                            "FROM Sag " +
                            "WHERE Sag.Status = 'Åben'" +
                        ") " +
                    "AND Bolig.Kvadratmeter >= 145";

                //SQL COMMAND
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                try

                {
                    //OPEN CONNECTION
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    //EXECUTE READER (QUERY)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //RETRIEVE BoligBLL AND ADD IN boliger
                        while (reader.Read())
                        {
                            boliger.Add(new BoligBLL((int)reader["BoligID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            reader["Type"].ToString(),
                            (int)reader["Værelser"],
                            (int)reader["Etager"],
                            (int)reader["Kvadratmeter"],
                            (int)reader["Udbudspris"],
                            (bool)reader["HaveFlag"],
                            (DateTime)reader["Bygningsår"],
                            (DateTime)reader["RenoveringsÅr"]));
                        }

                        //CLOSE READER
                        if (reader != null)
                            reader.Close();
                    }

                    //COMMIT OR ROLLBACK
                    if (!Transactions.Commit(conn))
                        Transactions.Rollback(conn);

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //CLOSE CONNECTION
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            //SORT
            boliger.Sort();

            //there is a very nice lambda function that can sort by two criteria
            //boliger = boliger.OrderBy(x => x.Vej).ThenBy(x => x.Udbudspris).ToList();

            //RETURN
            return boliger;
        }

        public override void GenerateBolig()
        {
            while (true) //ALWAYS
            {
                //CHECK IF OUTPUT IS NOT DISPOSED
                if (!output.IsDisposed)
                {
                    //THREAD THAT CALLS FetchBolig WITH A LAMBA FUNCTION (since the method has a return argument)
                    //this will give the user a list of BoligBLL always up to date
                    //ThreadStart start = new ThreadStart(() => FetchBolig());
                    //Thread t1 = new Thread(start);

                    //the list from FetchBoliger is saved in boliger
                    List<BoligBLL> boliger = FetchBolig();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated)
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //invoking DisplayBolig since Windows Form is not thread safe
                        output.Invoke(new DisplayDelegate(DisplayBolig), new object[] { boliger });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Thread.Sleep(1000);
                }
            }
        }
    }
}
