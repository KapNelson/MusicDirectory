namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayOn")]
    public partial class PlayOn
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MusInstrumentName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Musician { get; set; }

        public virtual Musician Musician { get; set; }
        public virtual MusInstruments MusInstruments { get; set; }
    }
}
