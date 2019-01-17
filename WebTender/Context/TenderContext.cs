using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebTender.Context.Entities;

namespace WebTender.Context
{
    public class TenderContext: DbContext
    {
        public TenderContext() : base("DefaultConnection")
        {
        }

        public DbSet<Tender> Tenders { get; set; }
    }
}