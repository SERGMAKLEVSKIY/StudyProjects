using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebTender.Context.Catalogs;
using WebTender.Context.Entities;

namespace WebTender.Models
{
    public class TenderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, DisplayName("Number of tender")]
        public int NumberOfTender { get; set; }

        [Required, StringLength(50), DisplayName("Subject of tender")]
        public string SubjectOfTender { get; set; }

        [Required, StringLength(1000)]
        public string Discription { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Выбери организатора")]
        public Organizer Organizer { get; set; }

        [Required, DisplayName("Type of tender")]
        [Range(1, int.MaxValue, ErrorMessage = "Выбери тип тендера")]
        public TenderType TenderType { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Выбери категорию")]
        public Category Category { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Выбери валюту")]
        public Currency Currency { get; set; }

        [Required, DisplayName("Publication Date")]
        public DateTime PublicationDate { get; set; }

        [Required, DisplayName("Admission time from: ")]
        public DateTime StartDate { get; set; }

        [Required, DisplayName("to: ")]
        public DateTime FinishDate { get; set; }

    }
}