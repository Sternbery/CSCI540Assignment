//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveySays.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyMCA
    {
        public int MCAID { get; set; }
        public int ResponseID { get; set; }
        public int QuestionID { get; set; }
        public int Answer { get; set; }
        public System.TimeSpan TimeTaken { get; set; }
    
        public virtual SurveyQuestion SurveyQuestion { get; set; }
        public virtual SurveyResponse SurveyResponse { get; set; }
    }
}
