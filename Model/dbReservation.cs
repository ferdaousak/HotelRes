using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelReservation.Model
{
    public class dbReservation
    {
        String dbinfo = "server=localhost;userid=root;database=hotelres";
        private static MySqlConnection cnx = null;
        public dbReservation()
        {
            try
            {
                if(cnx == null)
                    cnx = new MySqlConnection(dbinfo);
            }
            catch(Exception E)
            {
                Console.WriteLine("Error : {0}", E.ToString());
            }
        }

        public List<Chambre> GetAllChambres()
        {
            List<Chambre> chambres = new List<Chambre>();

            String query = "SELECT * From chambre;";
            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    int id = (int)rdr[0];
                    int type = (int)rdr[1];
                    String numero = (String)rdr[2];

                    chambres.Add(new Chambre(id,type,numero));
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }

            cnx.Close();
            return chambres;
        }

        public static int isReserved(int idchambre,DateTime date)
        {
            String query = "Select * from reservation where chambre_id = " + idchambre + " AND dateReservation LIKE '%" +date.ToString("yyyy-MM-dd")+"%';";
            Console.WriteLine(query);
            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int user_id = (int)rdr[1];

                    cnx.Close();
                    return user_id;
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }

            cnx.Close();
            return -1;
        }
        public int isUserExist(String username)
        {
            String query = "Select * from client where nom = '" + username + "';";

            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int user_id = (int)rdr[0];
                    Console.WriteLine("user found .... id:" + user_id);
                    cnx.Close();

                    return user_id;
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }

            cnx.Close();
            return -1;
        }
        public static String getUsernameFromId(int id)
        {
            String query = "Select * from client where id = " + id + ";";

            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String username = (String)rdr[1];
                    Console.WriteLine("user found .... username:" + username);
                    cnx.Close();

                    return username;
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }

            cnx.Close();
            return null;
        }
        public static List<Type> getAllTypes()
        {
            List<Model.Type> list = new List<Type>();
            String query = "SELECT * From type;";
            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int)rdr[0];
                    String classe = (String)rdr[1];

                    Console.WriteLine("id :" + id + "classe " + classe);
                    list.Add(new Type(id,classe));
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }

            cnx.Close();
            return list;
        }

        private int AddUser(String username)
        {
            int user_id = isUserExist(username);
            if(user_id == -1)
            {
                Console.WriteLine("user doesnt exist .... adding it to Database! ");
                try
                {
                    cnx.Open();
                    MySqlCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "INSERT INTO client(nom) VALUES(?nom)";
                    cmd.Parameters.Add("?nom", MySqlDbType.VarChar).Value = username;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : {0}", e.ToString());
                }
                cnx.Close();
            }
            else
            {
                return user_id;
            }
            return this.isUserExist(username);
        }

        public void ReservChambre(String username, int chambre_id, DateTime dateResrevation, int duree)
        {
            int user_id = this.AddUser(username);

            try
            {
                cnx.Open();
                MySqlCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "INSERT INTO reservation(client_id,chambre_id,dateReservation,duree) VALUES(?user_id,?chambre_id,?dateReservation,?duree)";
                cmd.Parameters.Add("?user_id", MySqlDbType.Int16).Value = user_id;
                cmd.Parameters.Add("?chambre_id", MySqlDbType.Int16).Value = chambre_id;
                cmd.Parameters.Add("?dateReservation", MySqlDbType.DateTime).Value = dateResrevation;
                cmd.Parameters.Add("?duree", MySqlDbType.Int16).Value = duree;
                Console.WriteLine("reserv : " + cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }
            cnx.Close();
        }

        public static void libererChambre(userControls.ucChambre chambre)
        {
            try
            {
                cnx.Open();
                MySqlCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "DELETE FROM reservation where chambre_id = ?chambre_id AND dateReservation LIKE ?dateReservation";
                cmd.Parameters.Add("?chambre_id", MySqlDbType.Int16).Value = chambre.chambre.id;
                cmd.Parameters.Add("?dateReservation", MySqlDbType.VarChar).Value = chambre.date.ToString("yyyy-MM-dd");
                Console.WriteLine("liberer : " + cmd.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.ToString());
            }
            cnx.Close();
        }
    }
}