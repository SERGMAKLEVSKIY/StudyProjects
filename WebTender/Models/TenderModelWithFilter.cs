using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WebTender.Context.Catalogs;

namespace WebTender.Models
{
    public class TenderModelWithFilter
    {
        public string FilterText { get; set; }

        public string SortOrder { get; set; }

        public Organizer? Organizer { get; set; }

        [DisplayName("Type")]
        public TenderType? TenderType { get; set; }

        [DisplayName("Date")]
        public DateTime PublicationDate { get; set; }

        public decimal Budget { get; set; }

        [DisplayName("Time from: ")]
        public DateTime? StartDate { get; set; }

        [DisplayName("to: ")]
        public DateTime? FinishDate { get; set; }

        public List<TenderModel> Tenders { get; set; }

        public int PageNumber { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}