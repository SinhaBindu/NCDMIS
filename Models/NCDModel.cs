using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCDMIS.Models
{
    public class NCDModel
    {
        public NCDModel() {
            ID=Guid.NewGuid();  
        }
        public System.Guid ID { get; set; }
        [Required]
        public Nullable<int> Age { get; set; }
        [Required]
        public string Block_name { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Does_his_or_her_BP_reading_systolic_140mm_Hg_or_higher_and_or_diastolic_90mm_Hg_or_higher_fall_under_hypertensive_range { get; set; }
        [Required]
        public string Does_his_or_her_RBS_reading_more_than_140mgdl_fall_under_diabetic_range { get; set; }
        [Required]
        public string Has_this_person_been_followed_up_by_NCD_Mitra { get; set; }
        [Required]
        public string Has_this_person_been_recommended_to_visit_the_PHC_to_consult_the_doctor { get; set; }
        [Required]
        public string Have_you_started_with_the_medication { get; set; }
        [Required]
        public string Household_ID { get; set; }
        [Required]
        public string Household_head_name { get; set; }
        [Required]
        public string Hypertension_reading { get; set; }
        [Required]
        public string If_yes_where_did_he_or_she_visit_for_the_check_up { get; set; }
        [Required]
        public string If_yes_whether_the_person_is_continuing_with_medication { get; set; }
        [Required]
        public string If_yes_whom_does_he_or_she_consults_for_medication { get; set; }
        [Required]
        public string Member_ID { get; set; }
        [Required]
        public string Member_name { get; set; }
        [Required]
        public string Member_or_household_head_Mobile_number { get; set; }
        [Required]
        public string NCD_volunteer_name { get; set; }
        [Required]
        public string Panchayat_name { get; set; }
        [Required]
        public string Random_blood_sugar_reading { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Village_name { get; set; }
        [Required]
        public string What_was_the_result_of_check_up_by_a_medical_doctor { get; set; }
        [Required]
        public string Whether_the_NCD_mitra_has_asha_plus_device { get; set; }
        [Required]
        public string Whether_the_member_is_already_a_patient_of_diabetes { get; set; }
        [Required]
        public string Whether_the_member_is_already_a_patient_of_hypertension { get; set; }
        [Required]
        public string Whether_this_person_has_started_making_changes_in_their_dietary_habit { get; set; }
        [Required]
        public string Whether_this_person_has_started_regular_exercise_or_yoga { get; set; }
        [Required]
        public string Whether_this_person_has_started_with_destressing_practices { get; set; }
        [Required]
        public string Whether_this_person_has_taking_8_hours_of_sound_sleep { get; set; }
        [Required]
        public string Whether_this_person_has_visited_Sub_centre_or_Primary_Health_Centre_for_blood_sugar_screening_by_a_medical_doctor { get; set; }
        [Required]
        public string Whether_this_person_has_visited_Subcentre_or_Primary_Health_Centre_for_BP_screening_by_a_medical_doctor { get; set; }
        [Required]
        public string UniqueKey { get; set; }
        public Nullable<bool> IsAtcive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}