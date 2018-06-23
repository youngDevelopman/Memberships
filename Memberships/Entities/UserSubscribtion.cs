using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    public class UserSubscribtion
    {
        [Required]
        [Key,Column(Order = 1)]
        public int SubscribtionId { get; set; }
        
        [Required]
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        public string UserId { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}