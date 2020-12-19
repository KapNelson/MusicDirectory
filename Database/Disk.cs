namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Disk")]
    public partial class Disk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disk()
        {
            Mixed = new HashSet<Mixed>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchNumber { get; set; }

        [StringLength(50)]
        public string Manufacturer { get; set; }

        [StringLength(50)]
        public string DiskName { get; set; }

        public int NumberOfTracks { get; set; }

        public int? Circulation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        public virtual Alyubomin Alyubomin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mixed> Mixed { get; set; }
    }
}
