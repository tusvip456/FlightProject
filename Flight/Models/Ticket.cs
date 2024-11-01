namespace Flight.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            Payments = new HashSet<Payment>();
        }

        public int TicketId { get; set; }

        public int UserId { get; set; }

        public int FlightId { get; set; }

        public DateTime BookingDate { get; set; }

        [StringLength(10)]
        public string SeatNumber { get; set; }

        public virtual Flight Flight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual User User { get; set; }
    }
}
