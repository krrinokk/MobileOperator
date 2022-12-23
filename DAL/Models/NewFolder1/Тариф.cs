namespace DAL.Models.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Тариф
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тариф()
        {
            Dogovor = new HashSet<Dogovor>();
        }

        [Column("Минута межгород стоимость", TypeName = "money")]
        public decimal? Минута_межгород_стоимость { get; set; }

        [Column("Минута международная стоимость", TypeName = "money")]
        public decimal Минута_международная_стоимость { get; set; }

        [Column("Название тарифа")]
        [Required]
        [StringLength(50)]
        public string Название_тарифа { get; set; }

        [Column("Стоимость перехода", TypeName = "money")]
        public decimal Стоимость_перехода { get; set; }

        [Column("Код типа тарифа FK")]
        public int Код_типа_тарифа_FK { get; set; }

        [Key]
        [Column("Код тарифа")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код_тарифа { get; set; }

        public int? Год_начала { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor> Dogovor { get; set; }

        public virtual Тип_тарифа Тип_тарифа { get; set; }
    }
}
