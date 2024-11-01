namespace Flight.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Flight()
        //{
        //    Tickets = new HashSet<Ticket>();
        //}

        //public int FlightId { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string DepartureLocation { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string DestinationLocation { get; set; }

        //public DateTime DepartureTime { get; set; }

        //public DateTime ArrivalTime { get; set; }

        //[Required]
        //[StringLength(20)]
        //public string FlightNumber { get; set; }

        //[StringLength(50)]
        //public string Airline { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
