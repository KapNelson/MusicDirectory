namespace MusicDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Solo")]
    public partial class Solo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Artist { get; set; }

        public int ID_Musician { get; set; }
        public virtual Performer Performer { get; set; }
        public virtual Musician Musician { get; set; }
    }
}
