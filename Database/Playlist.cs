namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Playlist")]
    public partial class Playlist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Track { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Login { get; set; }


        public virtual Track Track { get; set; }
        public virtual Users Users { get; set; }
    }
}
