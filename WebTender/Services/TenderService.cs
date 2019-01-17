using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTender.Context.Entities;
using WebTender.Models;

namespace WebTender.Services
{
    public class TenderService : Service, ITenderService
    {

        public List<TenderModel> GetAll()
        {
            return db.Tenders.Select(ten => new TenderModel
            {
                Id = ten.Id,
                NumberOfTender = ten.NumberOfTender,
                SubjectOfTender = ten.SubjectOfTender,
                Discription = ten.Discription,
                Organizer = ten.Organizer,
                TenderType = ten.TenderType,
                Category = ten.Category,
                Budget = ten.Budget,
                Currency = ten.Currency,
                PublicationDate = ten.PublicationDate,
                StartDate = ten.StartDate,
                FinishDate = ten.FinishDate
            }).ToList();
        }

       /* public IEnumerable<DateTime> GetAllDatesStart()
        {
            IEnumerable<DateTime> timesS = new List<DateTime>();
            timesS = db.Tenders.Select(d => d.StartDate).ToList();
            return timesS;
        }

        public IEnumerable<DateTime> GetAllDatesFinish()
        {
            IEnumerable<DateTime> timesF = new List<DateTime>();
            timesF = db.Tenders.Select(d => d.FinishDate).ToList();
            return timesF;
        }*/


        public TenderModelWithFilter GetByFilter(TenderModelWithFilter model)
        {

            IQueryable<Tender> query = db.Tenders;

            const int pageCount = 3;//---------------------------------

            if (!string.IsNullOrWhiteSpace(model.FilterText))
            {
                query = query.Where(ten => ten.SubjectOfTender.Contains(model.FilterText) || ten.Discription.Contains(model.FilterText));
            }

            if (model.Organizer != null)
            {
                query = query.Where(ten => ten.Organizer == model.Organizer);
            }

            if (model.TenderType != null)
            {
                query = query.Where(ten => ten.TenderType == model.TenderType);
            }

            if (model.StartDate != null )
            {
                query = query.Where(ten => ten.StartDate >= model.StartDate);
            }

            if (model.FinishDate != null)
            {
                query = query.Where(ten => ten.FinishDate <= model.FinishDate);
            }


            if (!string.IsNullOrWhiteSpace(model.SortOrder))
            {
                if (model.SortOrder == "Category")
                {
                    query = query.OrderBy(ten => ten.Category);
                }
                else if (model.SortOrder == "Budget")
                {
                    query = query.OrderBy(ten => ten.Budget);
                }
                else if (model.SortOrder == "PublicationDate")
                {
                    query = query.OrderBy(ten => ten.PublicationDate);
                }
            }

       
          var tenders =  query.Select(ten => new TenderModel
            {
                Id = ten.Id,
                NumberOfTender = ten.NumberOfTender,
                SubjectOfTender = ten.SubjectOfTender,
                Discription = ten.Discription,
                Organizer = ten.Organizer,
                TenderType = ten.TenderType,
                Category = ten.Category,
                Budget = ten.Budget,
                Currency = ten.Currency,
                PublicationDate = ten.PublicationDate,
                StartDate = ten.StartDate,
                FinishDate = ten.FinishDate
            }).Skip((model.PageNumber - 1) * pageCount).Take(pageCount).ToList();
            TenderModelWithFilter coll = new TenderModelWithFilter();
            coll.Tenders = tenders;

            PageInfo page = new PageInfo
            {
                PageSize = pageCount,
                TotalItems = query.Count()
        };

           coll.PageInfo = page;
           coll.PageNumber = model.PageNumber;
            return coll;
        }
    

        public void Create(TenderModel model)
        {
            db.Tenders.Add(new Tender
            {
                Id = model.Id,
                NumberOfTender = model.NumberOfTender,
                SubjectOfTender = model.SubjectOfTender,
                Discription = model.Discription,
                Organizer = model.Organizer,
                TenderType = model.TenderType,
                Category = model.Category,
                Budget = model.Budget,
                Currency = model.Currency,
                PublicationDate = model.PublicationDate,
                StartDate = model.StartDate,
                FinishDate = model.FinishDate
            });

            db.SaveChanges();
        }

        public TenderModel GetById(int Id)
        {

            return (from t in db.Tenders
                    where t.Id == Id
                    select (new TenderModel
                    {
                        Id = t.Id,
                        NumberOfTender = t.NumberOfTender,
                        SubjectOfTender = t.SubjectOfTender,
                        Discription = t.Discription,
                        Organizer = t.Organizer,
                        TenderType = t.TenderType,
                        Category = t.Category,
                        Budget = t.Budget,
                        Currency = t.Currency,
                        PublicationDate = t.PublicationDate,
                        StartDate = t.StartDate,
                        FinishDate = t.FinishDate
                    })).Single();
        }
    } 

}