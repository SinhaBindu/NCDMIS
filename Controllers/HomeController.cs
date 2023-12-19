using NCDMIS.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NCDMIS.Controllers
{
    public class HomeController : Controller
    {
        NCD_DBEntities db = new NCD_DBEntities();
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        // [ActionName("NCDData")]
        public JsonResult PostNCDData(List<NCDModel> model)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"];
            NCD_DBEntities db_ = new NCD_DBEntities();
            string error = "There was a communication error.";
            string Success = "Record Submitted!!";
            string AlreadyExists = "This record is Already Exists !!";
            string Rq = "All filed Required";
            string STRTokenmsg = "Security Token key not match.";
            string strtoken = "Bearer 8FB75006-70CC-4746-A610-9EC4BB358FE8"; //"8FB75006-70CC-4746-A610-9EC4BB358FE8";
            string strMsg = "";
            if (!ModelState.IsValid)
            {
                return Json(Rq, JsonRequestBehavior.AllowGet);
            }
            try
            {
                if ((accessToken).ToLower() == (strtoken).ToLower())
                {
                    List<tbl_NCD> tbllist = new List<tbl_NCD>();
                    tbl_NCD tbl;
                    if (model != null)
                    {
                        foreach (var item in model.ToList())
                        {
                            if (item != null)
                            {
                                //if (item.SecurityToken.ToLower() == strtoken.ToLower())
                                //{
                                if (!db_.tbl_NCD.Any(x => x.UniqueKey == item.UniqueKey))
                                {
                                    //if (db_.tbl_NCD.Any(x => x.UniqueKey == model.UniqueKey))
                                    //{
                                    //    return Json(AlreadyExists, JsonRequestBehavior.AllowGet);
                                    //}
                                    tbl = new tbl_NCD()
                                    {
                                        ID = Guid.NewGuid(),
                                        Age = item.Age,
                                        Block_name = item.Block_name,
                                        Date = item.Date,
                                        Does_his_or_her_BP_reading_systolic_140mm_Hg_or_higher_and_or_diastolic_90mm_Hg_or_higher_fall_under_hypertensive_range = item.Does_his_or_her_BP_reading_systolic_140mm_Hg_or_higher_and_or_diastolic_90mm_Hg_or_higher_fall_under_hypertensive_range,
                                        Does_his_or_her_RBS_reading_more_than_140mgdl_fall_under_diabetic_range = item.Does_his_or_her_RBS_reading_more_than_140mgdl_fall_under_diabetic_range,
                                        Has_this_person_been_followed_up_by_NCD_Mitra = item.Has_this_person_been_followed_up_by_NCD_Mitra,
                                        Has_this_person_been_recommended_to_visit_the_PHC_to_consult_the_doctor = item.Has_this_person_been_recommended_to_visit_the_PHC_to_consult_the_doctor,
                                        Have_you_started_with_the_medication = item.Have_you_started_with_the_medication,
                                        Household_ID = item.Household_ID,
                                        Household_head_name = item.Household_head_name,
                                        Hypertension_reading = item.Hypertension_reading,
                                        If_yes_where_did_he_or_she_visit_for_the_check_up = item.If_yes_where_did_he_or_she_visit_for_the_check_up,
                                        If_yes_whether_the_person_is_continuing_with_medication = item.If_yes_whether_the_person_is_continuing_with_medication,
                                        If_yes_whom_does_he_or_she_consults_for_medication = item.If_yes_whom_does_he_or_she_consults_for_medication,
                                        Member_ID = item.Member_ID,
                                        Member_name = item.Member_name,
                                        Member_or_household_head_Mobile_number = item.Member_or_household_head_Mobile_number,
                                        NCD_volunteer_name = item.NCD_volunteer_name,
                                        Panchayat_name = item.Panchayat_name,
                                        Random_blood_sugar_reading = item.Random_blood_sugar_reading,
                                        Sex = item.Sex,
                                        Village_name = item.Village_name,
                                        What_was_the_result_of_check_up_by_a_medical_doctor = item.What_was_the_result_of_check_up_by_a_medical_doctor,
                                        Whether_the_NCD_mitra_has_asha_plus_device = item.Whether_the_NCD_mitra_has_asha_plus_device,
                                        Whether_the_member_is_already_a_patient_of_diabetes = item.Whether_the_member_is_already_a_patient_of_diabetes,
                                        Whether_the_member_is_already_a_patient_of_hypertension = item.Whether_the_member_is_already_a_patient_of_hypertension,
                                        Whether_this_person_has_started_making_changes_in_their_dietary_habit = item.Whether_this_person_has_started_making_changes_in_their_dietary_habit,
                                        Whether_this_person_has_started_regular_exercise_or_yoga = item.Whether_this_person_has_started_regular_exercise_or_yoga,
                                        Whether_this_person_has_started_with_destressing_practices = item.Whether_this_person_has_started_with_destressing_practices,
                                        Whether_this_person_has_taking_8_hours_of_sound_sleep = item.Whether_this_person_has_taking_8_hours_of_sound_sleep,
                                        Whether_this_person_has_visited_Sub_centre_or_Primary_Health_Centre_for_blood_sugar_screening_by_a_medical_doctor = item.Whether_this_person_has_visited_Sub_centre_or_Primary_Health_Centre_for_blood_sugar_screening_by_a_medical_doctor,
                                        Whether_this_person_has_visited_Subcentre_or_Primary_Health_Centre_for_BP_screening_by_a_medical_doctor = item.Whether_this_person_has_visited_Subcentre_or_Primary_Health_Centre_for_BP_screening_by_a_medical_doctor,
                                        UniqueKey = item.UniqueKey,
                                        SecurityToken = item.SecurityToken,
                                        IsAtcive = true,
                                        CreatedBy = item.CreatedBy,
                                        CreatedOn = DateTime.Now,
                                    };
                                    tbllist.Add(tbl);
                                }
                                else
                                {
                                    strMsg += ", " + " UniqueKey " + item.UniqueKey + " " + AlreadyExists;
                                }

                            }
                        }
                        if (tbllist != null && tbllist.Count > 0)
                        {
                            db.tbl_NCD.AddRange(tbllist);
                            int res = db.SaveChanges();
                            if (res > 0)
                            {
                                return Json(Success + " " + strMsg, JsonRequestBehavior.AllowGet);
                            }
                        }
                        else
                        {
                            return Json(strMsg, JsonRequestBehavior.AllowGet);
                        }
                    }
                }
                else
                {
                    strMsg=STRTokenmsg;
                    return Json(strMsg, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception)
            {
                return Json(error, JsonRequestBehavior.AllowGet);
            }
            return Json(error, JsonRequestBehavior.AllowGet);
        }

        public async Task<JObject> PostAsync(string token, string url, string content)
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            WebRequest request = WebRequest.Create("http://localhost:44331/Home/PostAsync");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + token);
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                WebResponse response = await request.GetResponseAsync();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseContent = reader.ReadToEnd();
                    JObject adResponse =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
                    return adResponse;
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
                    {
                        string responseContent = reader.ReadToEnd();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
                    }
                }
            }

            return null;
        }

    }
}