namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musician")]
    public partial class Musician
    {
        [StringLength(50)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        public virtual Solo Solo { get; set; }

        [Key]
        public int ID_Musician { get; set; }
        public virtual ICollection<PlayOn> PlayOn { get; set; }
        public virtual ICollection<Participation> Participation { get; set; }
    }
}
