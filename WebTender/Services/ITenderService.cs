using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTender.Models;

namespace WebTender.Services
{
   public interface ITenderService
    {
        List<TenderModel> GetAll();
        void Create(TenderModel model);
        TenderModel GetById(int Id);
        TenderModelWithFilter GetByFilter(TenderModelWithFilter model);
    }
}
