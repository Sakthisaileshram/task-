using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientManagement.Models;
using System.Data;
namespace ClientManagement.Controllers
{
    public class ClientmMgntController : Controller
    {
        // GET: ClientmMgnt

        public ActionResult login()
        {
            return View("login");
        }
        

        public ActionResult Verify(FormCollection frm, string action)
        {
            ClientModel cmobj = new ClientModel();
            DataTable dt = cmobj.Getdata();
            string uname = frm["TB_user_name"];
            string password = frm["TB_password"];
            if (action == "Submit")
            {
         
                for (int i = 0;i<=dt.Rows.Count; i++)
                {
                  
                    if (uname == dt.Rows[i]["UserName"].ToString() && password == dt.Rows[i]["Pword"].ToString())
                    {
                        return View("Home");
                    }

                    else
                    { return View("login"); }

                }
            }

           


            return View("login");

          
        }
        public ActionResult home()
        { return View("Home"); }
        public ActionResult doc()
        {
           ClientModel cmobj = new ClientModel();
           DataTable dt = cmobj.GetDoctordata();
            return View("doctor",dt);
        }
        public ActionResult Docinsert()
        { return View("doctor"); }
        public ActionResult Idoctor(FormCollection dfrm, string action)
        {
           
          


            if (action == "Submit")
            {
               ClientModel cmobj = new ClientModel();
                string fname = dfrm["TB_f_name"];
                string lname = dfrm["TB_l_name"];
                string sex = dfrm["TB_gen"];
                string sppz = dfrm["TB_spezz"];
                string Vhrss = dfrm["TB_vhr"];
                int instatus = cmobj.insert_doctorData(fname,lname,sex,sppz,Vhrss);
             
                return RedirectToAction ("doc");

            }
            else 
            {
               
                return View("doc"); 
            }

           

        }

        public ActionResult Pat()
        {
            ClientModel cmobj = new ClientModel();
            DataTable dt = cmobj.GetPatientdata();
            return View("patient", dt);
        }
        public ActionResult patient(FormCollection pfrm,string action)
        {
            if (action == "Submit")
            {
                ClientModel cmobj = new ClientModel();
                string fname = pfrm["TB_Pf_name"];
                string lname = pfrm["TB_Pl_name"];
                string sex = pfrm["TB_Pgen"];
                string age = pfrm["TB_age"];
                string dob = pfrm["TB_dob"];
                int instatus = cmobj.insert_PatientData(fname, lname, sex, age, dob);

                // return View("patient");
                return RedirectToAction("Pat");

            }
            else
            {

                return View("patient");
            }



        }

        public ActionResult app(ClientModel cmobj)

        {
            //ClientModel cmobj = new ClientModel();
            cmobj.Doclist = cmobj.populateDocklist();
            var selectedItem = cmobj.Doclist.Find(p => p.Value == cmobj.firstName);
            // DataTable dt = cmobj.GetAppointmentdata();
            return View(cmobj);
        }
        public ActionResult appointment(FormCollection appfrm, string action)
        {
            ClientModel cmobj = new ClientModel();
             DataTable dt = cmobj.GetAppointmentdata();

            if (action == "Submit")
            {
               
                string id = appfrm["id"];
                string Spez = appfrm["dept"];
                //string dname = appfrm["TB_Pl_name"];
                string Vday = appfrm["TB_Vdate"].ToString();
                string time = appfrm["TB_AppTime"].ToString();
                //  int instatus = cmobj.insert_appointmentData(Spez, dname, Vday, time);
                int instatus = cmobj.insert_appointmentData( Convert.ToInt32(id),Spez, Vday, time);
                //return View("appointment");
                return RedirectToAction("app");

            }
            else
            {
                
                return View("appointment");

            }
        }
    }
}
   
