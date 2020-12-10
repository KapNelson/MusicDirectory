namespace MusicDirectory.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Performer")]
    public partial class Performer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performer()
        {
            Track = new HashSet<Track>();
        }

        [StringLength(20)]
        public string ArtistName { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string StyleName { get; set; }

        [Key]
        public int ID_Artist { get; set; }

        public virtual Band Band { get; set; }

        public virtual Style Style { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Track> Track { get; set; }

        public virtual Musician Musician { get; set; }
    }
}
