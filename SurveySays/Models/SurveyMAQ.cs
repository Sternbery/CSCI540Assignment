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
    
    public partial class SurveyMAQ
    {
        public int MAQID { get; set; }
        public int QuestionID { get; set; }
        public int ChoiceOrder { get; set; }
        public string Text { get; set; }
    
        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
