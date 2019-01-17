using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebTender.Context.Catalogs;

namespace WebTender.Context.Entities
{
    public class Tender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int NumberOfTender { get; set; }

        [Required, StringLength(50)]
        public string SubjectOfTender { get; set; }

        [Required, StringLength(1000)]
        public string Discription { get; set; }

        [Required]
        public Organizer Organizer { get; set; }

        [Required]
        public TenderType TenderType { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        public Currency Currency { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        public  DateTime  StartDate { get; set; }

        [Required]
        public DateTime FinishDate { get; set; }
    }
}