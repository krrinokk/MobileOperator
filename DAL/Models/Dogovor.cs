namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dogovor")]
    public partial class Dogovor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dogovor()
        {
            Call = new HashSet<Call>();
        }

        [Column(TypeName = "date")]
        public DateTime Дата_заключения { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер_договора { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер_телефона { get; set; }

        [Required]
        [StringLength(50)]
        public string Серийный_номер_сим_карты { get; set; }

        [Column(TypeName = "date")]
        //   public DateTime? Дата_расторжения { get; set; }
        public DateTime Дата_расторжения { get; set; }
        public int Код_тарифа_FK { get; set; }

        public int Номер_клиента_FK { get; set; }

       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
       public virtual ICollection<Call> Call { get; set; }

      public virtual Клиент Клиент { get; set; }

        public virtual Тариф Тариф { get; set; }
    }
}
