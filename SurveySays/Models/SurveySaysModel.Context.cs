﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SurveySaysDBEntities : DbContext
    {
        public SurveySaysDBEntities()
            : base("name=SurveySaysDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyMAA> SurveyMAAs { get; set; }
        public virtual DbSet<SurveyMAQ> SurveyMAQs { get; set; }
        public virtual DbSet<SurveyMCA> SurveyMCAs { get; set; }
        public virtual DbSet<SurveyMCQ> SurveyMCQs { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<SurveyResponse> SurveyResponses { get; set; }
        public virtual DbSet<SurveySAA> SurveySAAs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagSurvey> TagSurveys { get; set; }
        public virtual DbSet<TypeEnum> TypeEnums { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
