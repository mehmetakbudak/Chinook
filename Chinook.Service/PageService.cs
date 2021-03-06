using Chinook.Data;
using Chinook.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chinook.Service
{
    public interface IPageService
    {
        IQueryable<Page> GetAll();
    }

    public class PageService : IPageService
    {
        private readonly ChinookContext context;
        public PageService(ChinookContext context)
        {
            this.context = context;
        }

        public IQueryable<Page> GetAll()
        {
            return context.Pages.Where(x => !x.Deleted);
        }
    }
}
