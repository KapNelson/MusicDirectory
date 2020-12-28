namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Band")]
    public partial class Band
    {
        public int NumOfParticipants { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Artist { get; set; }

        public virtual Performer Performer { get; set; }
        public virtual ICollection<Participation> Participation { get; set; }
    }
}
