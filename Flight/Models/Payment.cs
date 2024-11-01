namespace Flight.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int PaymentId { get; set; }

        public int TicketId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
