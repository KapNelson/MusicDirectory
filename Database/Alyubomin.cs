namespace MusicDirectory.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alyubomin")]
    public partial class Alyubomin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchNumber { get; set; }

        public int? ID_Album { get; set; }

        public virtual Album Album { get; set; }

        public virtual Disk Disk { get; set; }
    }
}
