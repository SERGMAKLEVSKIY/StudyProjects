using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTender.Context.Catalogs;

namespace WebTender.Models
{
    public class FilterModel
    {
        public string Filter { get; set; }

        public string OrderBy { get; set; }

        public Organizer? Organizer { get; set; }

        public TenderType? TenderType { get; set; }

        public int PageNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        /*  public List<SelectListItem> Organizers
          {
              get
              {
                  return new List<SelectListItem>
                  {
                      new SelectListItem
                      {
                          Text = "Киевский метрополитен",
                          Value = Context.Catalogs.Organizer.Киевский_метрополитен.ToString()
                      }
                  };
              }
      }*/
    }
}