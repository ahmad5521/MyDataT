namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public User()
        //{
        //    ConstCompetitions = new HashSet<ConstCompetition>();
        //    User1 = new HashSet<User>();
        //}

        [Key]
        public decimal userNationalID { get; set; }

        [StringLength(20)]
        public string name_A { get; set; }

        [StringLength(20)]
        public string secondName_A { get; set; }

        [StringLength(20)]
        public string thirdName_A { get; set; }

        [StringLength(25)]
        public string lastName_A { get; set; }
        
    }
}
