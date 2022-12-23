namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Call")]
    public partial class Call
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime Дата_и_время { get; set; }

        //[Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Длительность { get; set; }

      //  [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Стоимость { get; set; }

       // [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер_договора_FK { get; set; }

      //  [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код_типа_звонка_FK { get; set; }

        public virtual Dogovor Dogovor { get; set; }

        public virtual Тип_звонка Тип_звонка { get; set; }
    }
}
