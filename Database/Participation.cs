namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participation")]
    public partial class Participation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Artist { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Musician { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public virtual Musician Musician { get; set; }
        public virtual Band Band { get; set; }
    }
}
