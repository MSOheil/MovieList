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
    
    public partial class MovieModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieModel()
        {
            this.CommentModels = new HashSet<CommentModel>();
            this.GenresToMovies = new HashSet<GenresToMovie>();
        }
    
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public int DateProduction { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentModel> CommentModels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GenresToMovie> GenresToMovies { get; set; }
    }
}
