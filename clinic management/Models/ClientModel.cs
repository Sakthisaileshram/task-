using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace ClientManagement.Models
{

    public class ClientModel
    {
        SqlConnection con;


        public ClientModel()
        {
            con = new SqlConnection("Data source =LAPTOP-2MS5KE03; database =Clientmgmt; integrated security=true");

        }

        public DataTable Getdata()
        {
            string selqry = "select UserName,Pword from loginDeets";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetDoctordata()
        {
            string selqry = "select firstName,lastName,sex,specialization,visiting_hours from doctor";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int insert_doctorData(string fn, string ln, string gen, string spez, string vhr)
        {
            string insDqry = "insert into doctor values (@fn,@ln,@gen,@spez,@vhr)";// values(@Fname,@Lname,@sez,@spz,@Vhours)";
            SqlCommand cmd = new SqlCommand(insDqry, con);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@gen", gen);
            cmd.Parameters.AddWithValue("@spez", spez);
            cmd.Parameters.AddWithValue("@vhr", vhr);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }  
            
        

        public DataTable GetPatientdata()
        {
            string selqry = "select patient_id,firstName,lastName,sex,Age,DOB from tbl_Patient";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

            public int insert_PatientData(string fn, string ln, string gen, string age, string dob)
            {
            string insDqry = "insert into tbl_Patient values (@fn,@ln,@gen,@age,@dob)";
            SqlCommand cmd = new SqlCommand(insDqry, con);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@gen", gen);
            cmd.Parameters.AddWithValue("@age",age );
            cmd.Parameters.AddWithValue("@dob", dob);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();


            }
        public DataTable GetAppointmentdata()
        {
          //  string selqry = "select Patient_id,Specialization,visiting_day,time_slot from Appointment";
            string qry = "select ap.Patient_id,ap.Specialization,doctorName,visiting_day,time_slot from Appointment ap join doctor doc on doc.specialization = ap.Specialization join tbl_patient pat on pat.patient_id = ap.Patient_id";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public List<SelectListItem> Doclist { get; set; }
        public string firstName { get; set; }

        public List<SelectListItem> populateDocklist()
        {
            List<SelectListItem> dlist = new List<SelectListItem>();
            string selqry = "select firstName from doctor";
            SqlCommand cmd = new SqlCommand(selqry, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                Doclist.Add(new SelectListItem { Text = rdr["firstName"].ToString(), Value= rdr["firstName"].ToString() }) ;

            con.Close();
            return dlist;
        }

        // public int insert_appointmentData(string sp, string dn, string vd, string t)
        public int insert_appointmentData(int id,string sp, string vd, string t)
        {
           // string insDqry = "insert into Appointment values (@sp,@dn,@vd,@t)";
            string insDqry = "insert into Appointment values (@sp,@vd,@t)";
            SqlCommand cmd = new SqlCommand(insDqry, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@sp", sp);
            //cmd.Parameters.AddWithValue("@dn", dn);
            cmd.Parameters.AddWithValue("@vd", vd);
            cmd.Parameters.AddWithValue("@t", t);
            
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();

        }
    }
    }