namespace Mentally_DB_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Gangguan { get; set; }

        [Required]
        [StringLength(100)]
        public string Solusi_1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Solusi_2 { get; set; }

        [Required]
        [StringLength(100)]
        public string Solusi_3 { get; set; }

        [Required]
        [StringLength(100)]
        public string Solusi_4 { get; set; }
    }
}
