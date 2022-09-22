namespace GlazkiApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            AgentPriorityHistory = new HashSet<AgentPriorityHistory>();
            ProductSale = new HashSet<ProductSale>();
            Shop = new HashSet<Shop>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int AgentTypeID { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(9)]
        public string KPP { get; set; }

        [StringLength(100)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public int Priority { get; set; }

        public virtual AgentType AgentType { get; set; }

        public int diskaunt 
        {
            get
            {
                int diskaunt = 0;
                int qtyAllPeriod = 0;
                decimal sumAllPeriod = 0;

                foreach (ProductSale sale in ProductSale)
                {
                    qtyAllPeriod += sale.ProductCount;
                    sumAllPeriod += qtyAllPeriod * sale.Product.MinCostForAgent;
                }

                if (sumAllPeriod < 10000)
                {
                   diskaunt = 0;
                }
                else if (sumAllPeriod >= 10000 && sumAllPeriod <= 50000)
                {
                    diskaunt = 5;
                }
                else if (sumAllPeriod >= 50000 && sumAllPeriod <= 150000)
                {
                    diskaunt = 10;
                }
                else if (sumAllPeriod >= 150000 && sumAllPeriod <= 500000)
                {
                    diskaunt = 20;
                }
                else
                {
                    diskaunt = 25;
                }
                return diskaunt;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentPriorityHistory> AgentPriorityHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shop { get; set; }
    }
}
