namespace DAL.Models.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиент
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиент()
        {
            Dogovor = new HashSet<Dogovor>();
        }

        [Key]
        [Column("Номер клиента")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер_клиента { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [Column(TypeName = "money")]
        public decimal? Баланс { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor> Dogovor { get; set; }
    }
}
