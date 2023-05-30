using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması.dao
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        public Repository() 
        {
            con= new SqlConnection("Data Source=LAPTOP-HUKRTS1G;Initial Catalog=takvim;Persist Security Info=True;User ID=sa;password=1");
        }
        public user login(string username, string password)
        {
            con.Open();
            cmd = new SqlCommand("select * from logintable where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user user = new user();
                user.id = int.Parse(dr["id"].ToString());
                user.username = dr["username"].ToString();
                user.password = dr["password"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.email = dr["email"].ToString();
                user.status = LoginStatus.başarılı;
                return user;
            }
            else
            {
                user user = new user();
                user.status = LoginStatus.başarısız;
                return user;
            }

        }
        public string checkmailaddres(string username)
        {
            con.Open();
            cmd = new SqlCommand("select email from logintable where username=@username", con);
            cmd.Parameters.AddWithValue("@username", username);
            string email = (string)cmd.ExecuteScalar();
            con.Close();
            return email;
        }
        public LoginStatus changepassword(string username, string password)
        {
            con.Open();
            cmd = new SqlCommand("sifreguncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            con.Close();
            return LoginStatus.başarılı;
        }
        public LoginStatus insertuser(user user) 
        {
            con.Open();
            cmd = new SqlCommand("insertuser_sp", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", user.name);
            cmd.Parameters.AddWithValue("@surname", user.surname);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue ("@Password", user.password);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@tc", user.tc);
            cmd.Parameters.AddWithValue("@telefon", user.telefon);
            cmd.Parameters.AddWithValue("@adres", user.adres);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if(returnvalue == 1) 
            {
                return LoginStatus.başarılı;
            }
            else 
            {
                return LoginStatus.başarısız;
            }
        }
        public List<user>getallusers() 
        {
            List<user> list = new List<user>();
            con.Open();
            cmd = new SqlCommand("select * from logintable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
              user user=new user();
                user.id = int.Parse(dr["id"].ToString());
                user.name = dr["name"].ToString();
                user.surname = dr["surname"].ToString();
                user.username = dr["username"].ToString();
                user.password = dr["password"].ToString();
                user.email = dr["email"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.tc = dr["tc"].ToString();
                user.adres = dr["adres"].ToString();
                list.Add(user);
            }
            con.Close();
            return list;
        }
        public LoginStatus assignadmin(string tc) 
        {
            con.Open();
            cmd = new SqlCommand("update logintable set yetki='admin' where tc=@tc", con);
            cmd.Parameters.AddWithValue("@tc", tc);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;
        }
        
        public LoginStatus removeusers(string tc)
        {
            con.Open();
            cmd = new SqlCommand("delete from logintable where tc=@tc", con);
            cmd.Parameters.AddWithValue("tc", tc);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;
        }
        public LoginStatus updateusers(user user) 
        {
            con.Open();
            cmd = new SqlCommand("updateusers_sp",con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tc", user.tc);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@email",user.email);
            cmd.Parameters.AddWithValue("@telefon", user.telefon);
            cmd.Parameters.AddWithValue("@adres", user.adres);
            returnvalue= cmd.ExecuteNonQuery ();
            con.Close();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;
        }
        public List<events> getevent(string username) 
        {
            List<events> listevent = new List<events>();
            con.Open();
            cmd = new SqlCommand("select * from eventable where username=@username",con);
            cmd.Parameters.AddWithValue("@username", username);
            dr=cmd.ExecuteReader();
            while (dr.Read()) 
            {
                events events = new events();
                events.id = int.Parse( dr["id"].ToString());
                events.username = dr["username"].ToString();
                events.olay = dr["olay"].ToString();
                //events.tarih = DateTime.Parse( dr["tarih"].ToString() );
                events.alarm = DateTime.Parse(dr["alarm"].ToString());
                listevent.Add(events);
            }
            con.Close();
            return listevent;
        }
        public LoginStatus updatevent(events events) 
        {
            con.Open();
            cmd = new SqlCommand("updateevent_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",events.id);
            cmd.Parameters.AddWithValue("@username", events.username);
            cmd.Parameters.AddWithValue("@olay", events.olay);
           // cmd.Parameters.AddWithValue("@tarih", events.tarih);
            cmd.Parameters.AddWithValue("@alarm",events.alarm);
            returnvalue= cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;
            
        }
        public LoginStatus removevent(int id,string username) 
        {
            con.Open();
            cmd = new SqlCommand("delete from eventable where id=@id and username=@username", con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue ("@username",username);
            returnvalue= cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;
        }
        public LoginStatus insertevent(events events) 
        {
            con.Open();
            cmd = new SqlCommand("insertevent_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", events.username);
            cmd.Parameters.AddWithValue("@olay", events.olay);
            cmd.Parameters.AddWithValue("@tarih", events.tarih);
            cmd.Parameters.AddWithValue("@alarm", events.alarm);
            returnvalue= cmd.ExecuteNonQuery ();
            if (returnvalue == 1)
                return LoginStatus.başarılı;
            else
                return LoginStatus.başarısız;

        }




    }
}
