//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movie.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommentModel
    {
        public int CommentID { get; set; }
        public string CommentName { get; set; }
        public double CommentRat { get; set; }
        public int MovieId { get; set; }
        public string CommentDescription { get; set; }
    
        public virtual MovieModel MovieModel { get; set; }
    }
}
