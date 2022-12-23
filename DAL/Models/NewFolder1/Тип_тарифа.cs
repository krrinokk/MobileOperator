namespace DAL.Models.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Тип тарифа")]
    public partial class Тип_тарифа
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тип_тарифа()
        {
            Тариф = new HashSet<Тариф>();
        }

        [Column("Название типа тарифа")]
        [StringLength(50)]
        public string Название_типа_тарифа { get; set; }

        [Key]
        [Column("Код типа тарифа")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код_типа_тарифа { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Тариф> Тариф { get; set; }
    }
}
