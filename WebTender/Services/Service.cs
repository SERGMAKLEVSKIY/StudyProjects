using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTender.Context;

namespace WebTender.Services
{
    public class Service : IDisposable
    {
        protected TenderContext db = new TenderContext();

        public void Dispose()
        {
            db.Dispose();
        }
    }
}