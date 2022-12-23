namespace DAL.Models.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Тип звонка")]
    public partial class Тип_звонка
    {
        [Column("Название типа звонка")]
        [StringLength(50)]
        public string Название_типа_звонка { get; set; }

        [Key]
        [Column("Код типа звонка")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код_типа_звонка { get; set; }
    }
}
