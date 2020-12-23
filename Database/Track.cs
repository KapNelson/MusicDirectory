namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Track")]
    public partial class Track
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Track()
        {
            Mixed = new HashSet<Mixed>();
        }

        [StringLength(50)]
        public string NameOfTrack { get; set; }

        public int? TrackRecYear { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public int? AlbumNumber { get; set; }

        [StringLength(50)]
        public string GenreName { get; set; }

        public int? ID_Album { get; set; }

        public int? ID_Artist { get; set; }

        public int NumberOfPlays { get; set; }

        [Key]
        public int ID_Track { get; set; }

        public virtual Album Album { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Performer Performer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mixed> Mixed { get; set; }
        public virtual ICollection<Playlist> Playlist { get; set; }
    }
}
