namespace MusicDirectory.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [StringLength(20)]
        public string Login { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public bool Admin { get; set; }
    }
}
