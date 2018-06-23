using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("SubscribitionProduct")]
    public class SubscribtionProduct
    {
        [Required]
        [Key,Column(Order = 1)]
        public int ProductId { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        public int SubscribtionId { get; set; }

        [NotMapped]
        public int OldProductId { get; set; }

        [NotMapped]
        public int OldSubscribtionId { get; set; }
    }
}