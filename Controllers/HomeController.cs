using NCDMIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public JsonResult PostNCDData(NCDModel model)
        {
            NCD_DBEntities db_ = new NCD_DBEntities();
            string error = "There was a communication error.";
            string Success = "Record Submitted!!";
            string AlreadyExists = "This record is Already Exists !!";
            string Rq = "All filed Required";
            if (!ModelState.IsValid)
            {
                return Json(Rq, JsonRequestBehavior.AllowGet);
            }
            try
            {
                if (db_.tbl_NCD.Any(x => x.UniqueKey == model.UniqueKey))
                {
                    return Json(AlreadyExists, JsonRequestBehavior.AllowGet);
                }
                tbl_NCD tbl = new tbl_NCD();
                tbl.ID = Guid.NewGuid();
                tbl.Age = model.Age;
                tbl.Block_name = model.Block_name;
                tbl.Date = model.Date;
                tbl.Does_his_or_her_BP_reading_systolic_140mm_Hg_or_higher_and_or_diastolic_90mm_Hg_or_higher_fall_under_hypertensive_range = model.Does_his_or_her_BP_reading_systolic_140mm_Hg_or_higher_and_or_diastolic_90mm_Hg_or_higher_fall_under_hypertensive_range;
                tbl.Does_his_or_her_RBS_reading_more_than_140mgdl_fall_under_diabetic_range = model.Does_his_or_her_RBS_reading_more_than_140mgdl_fall_under_diabetic_range;
                tbl.Has_this_person_been_followed_up_by_NCD_Mitra = model.Has_this_person_been_followed_up_by_NCD_Mitra;
                tbl.Has_this_person_been_recommended_to_visit_the_PHC_to_consult_the_doctor = model.Has_this_person_been_recommended_to_visit_the_PHC_to_consult_the_doctor;
                tbl.Have_you_started_with_the_medication = model.Have_you_started_with_the_medication;
                tbl.Household_ID = model.Household_ID;
                tbl.Household_head_name = model.Household_head_name;
                tbl.Hypertension_reading = model.Hypertension_reading;
                tbl.If_yes_where_did_he_or_she_visit_for_the_check_up = model.If_yes_where_did_he_or_she_visit_for_the_check_up;
                tbl.If_yes_whether_the_person_is_continuing_with_medication = model.If_yes_whether_the_person_is_continuing_with_medication;
                tbl.If_yes_whom_does_he_or_she_consults_for_medication = model.If_yes_whom_does_he_or_she_consults_for_medication;
                tbl.Member_ID = model.Member_ID;
                tbl.Member_name = model.Member_name;
                tbl.Member_or_household_head_Mobile_number = model.Member_or_household_head_Mobile_number;
                tbl.NCD_volunteer_name = model.NCD_volunteer_name;
                tbl.Panchayat_name = model.Panchayat_name;
                tbl.Random_blood_sugar_reading = model.Random_blood_sugar_reading;
                tbl.Sex = model.Sex;
                tbl.Village_name = model.Village_name;
                tbl.What_was_the_result_of_check_up_by_a_medical_doctor = model.What_was_the_result_of_check_up_by_a_medical_doctor;
                tbl.Whether_the_NCD_mitra_has_asha_plus_device = model.Whether_the_NCD_mitra_has_asha_plus_device;
                tbl.Whether_the_member_is_already_a_patient_of_diabetes = model.Whether_the_member_is_already_a_patient_of_diabetes;
                tbl.Whether_the_member_is_already_a_patient_of_hypertension = model.Whether_the_member_is_already_a_patient_of_hypertension;
                tbl.Whether_this_person_has_started_making_changes_in_their_dietary_habit = model.Whether_this_person_has_started_making_changes_in_their_dietary_habit;
                tbl.Whether_this_person_has_started_regular_exercise_or_yoga = model.Whether_this_person_has_started_regular_exercise_or_yoga;
                tbl.Whether_this_person_has_started_with_destressing_practices = model.Whether_this_person_has_started_with_destressing_practices;
                tbl.Whether_this_person_has_taking_8_hours_of_sound_sleep = model.Whether_this_person_has_taking_8_hours_of_sound_sleep;
                tbl.Whether_this_person_has_visited_Sub_centre_or_Primary_Health_Centre_for_blood_sugar_screening_by_a_medical_doctor = model.Whether_this_person_has_visited_Sub_centre_or_Primary_Health_Centre_for_blood_sugar_screening_by_a_medical_doctor;
                tbl.Whether_this_person_has_visited_Subcentre_or_Primary_Health_Centre_for_BP_screening_by_a_medical_doctor = model.Whether_this_person_has_visited_Subcentre_or_Primary_Health_Centre_for_BP_screening_by_a_medical_doctor;
                tbl.UniqueKey = model.UniqueKey;
                tbl.IsAtcive = true;
                tbl.CreatedBy = model.CreatedBy;
                tbl.CreatedOn = DateTime.Now;
                db.tbl_NCD.Add(tbl);
                int res = db.SaveChanges();
                if (res > 0)
                {
                    return Json(Success, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(error, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {
                return Json(error, JsonRequestBehavior.AllowGet);
            }
        }

    }
}