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
    
    public partial class TagSurvey
    {
        public int TagSurveyID { get; set; }
        public int SurveyID { get; set; }
        public int TagID { get; set; }
    
        public virtual Survey Survey { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
