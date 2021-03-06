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
    
    public partial class SurveyResponse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SurveyResponse()
        {
            this.SurveyMAAs = new HashSet<SurveyMAA>();
            this.SurveyMCAs = new HashSet<SurveyMCA>();
            this.SurveySAAs = new HashSet<SurveySAA>();
        }
    
        public int ResponseID { get; set; }
        public int UserID { get; set; }
        public int SurveyID { get; set; }
        public System.DateTime DateTaken { get; set; }
        public string TakerCode { get; set; }
    
        public virtual Survey Survey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyMAA> SurveyMAAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyMCA> SurveyMCAs { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveySAA> SurveySAAs { get; set; }
    }
}
