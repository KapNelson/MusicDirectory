namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MusInstruments
    {
        [Key]
        [StringLength(50)]
        public string MusInstrumentName { get; set; }
        public virtual ICollection<PlayOn> PlayOn { get; set; }
    }
}
