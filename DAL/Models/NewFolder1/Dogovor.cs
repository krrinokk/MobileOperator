namespace DAL.Models.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dogovor")]
    public partial class Dogovor
    {
        [Column("Дата заключения", TypeName = "date")]
        public DateTime Дата_заключения { get; set; }

        [Key]
        [Column("Номер договора")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер_договора { get; set; }

        [Column("Номер телефона")]
        [Required]
        [StringLength(50)]
        public string Номер_телефона { get; set; }

        [Column("Серийный номер сим карты")]
        [Required]
        [StringLength(50)]
        public string Серийный_номер_сим_карты { get; set; }

        [Column("Дата расторжения", TypeName = "date")]
        public DateTime? Дата_расторжения { get; set; }

        [Column("Код тарифа FK")]
        public int Код_тарифа_FK { get; set; }

        [Column("Номер клиента FK")]
        public int Номер_клиента_FK { get; set; }

        public virtual Клиент Клиент { get; set; }

        public virtual Тариф Тариф { get; set; }
    }
}
