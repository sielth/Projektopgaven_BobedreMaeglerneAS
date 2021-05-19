﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class KøberDAL
    {
        private KøberBLL KøberBLL;
        private ConnectionSingleton s1;
        private SqlConnection conn;

        public KøberDAL(KøberBLL køberBLL)
        {
            this.KøberBLL = køberBLL;
            this.s1 = ConnectionSingleton.Instance();
            this.conn = s1.GetConnection();
        }
        
        public void OpretKøber(KøberBLL køber) //Opretter køber
        {
            //Connection string
            //ConnectionSingleton s1 = ConnectionSingleton.Instance();
            //SqlConnection conn = s1.GetConnection();

            string sqlCommandKøber = "INSERT INTO Køber VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
            try
            {
                conn.Open();
                Transactions.BeginRepeatableReadTransaction(conn);
                cmdKøber.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                {
                    Transactions.Rollback(conn);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            //finally
            //{
            //    conn.Close();
            //}
            if (conn != null)
                conn.Close();
        }

        public KøberBLL FindKøber(KøberBLL køber)
        {
            //Connection string
            //ConnectionSingleton s1 = ConnectionSingleton.Instance();
            //SqlConnection conn = s1.GetConnection();

            string sqlCommandKøber = "SELECT * FROM Sælger WHERE SælgerID = @SæglerID";

            SqlCommand commandKøber = new SqlCommand(sqlCommandKøber, conn);

            commandKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
            try
            {
                conn.Open();
                Transactions.BeginRepeatableReadTransaction(conn);
                using (SqlDataReader reader = commandKøber.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KøberBLL matchingkøber = new KøberBLL((int)reader["KøberID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            (int)reader["CPR"],
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Email"].ToString(),
                            (int)reader["Telefon"]);

                        return matchingkøber;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            //finally
            //{
            //    conn.Close();
            //}
            if (conn != null)
                conn.Close();
            return null;
        }

        public void OpdaterKøber(KøberBLL køber) //Opdaterer køber
        {
            //Connection string
            //ConnectionSingleton s1 = ConnectionSingleton.Instance();
            //SqlConnection conn = s1.GetConnection();

            //ConnectionSingleton s1 = ConnectionSingleton.Instance();

            //Tjekker om tekstboxe var tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandKøber = "UPDATE Køber SET" +
                "CPR = IsNull(NullIf(@CPR, ''), CPR)," +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon)," +
                "Email = IsNull(NullIf(@Email, ''), Email)," +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn)," +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn)," +
                "Vej = IsNull(NullIf(@Vej, ''), Vej)," +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer)," +
                "WHERE KøberID = @KøberID";
            //Sender input til database for at opdatere
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
            try
            {
                conn.Open();
                Transactions.BeginRepeatableReadTransaction(conn);
                cmdKøber.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                {
                    Transactions.Rollback(conn);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            //finally
            //{
            //    conn.Close();
            //}
            if (conn != null)
                conn.Close();
        }

        public void SletKøber(KøberBLL køber) //Sletter køber
        {
            //Connection string
            //ConnectionSingleton s1 = ConnectionSingleton.Instance();
            //SqlConnection conn = s1.GetConnection();

            string sqlCommandKøber = "DELETE FROM Køber WHERE (@KøberID)";
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
            try
            {
                conn.Open();
                Transactions.BeginRepeatableReadTransaction(conn);
                cmdKøber.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                {
                    Transactions.Rollback(conn);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            //finally
            //{
            //    conn.Close();
            //}
            if (conn != null)
                conn.Close();
        }
        
    }
}