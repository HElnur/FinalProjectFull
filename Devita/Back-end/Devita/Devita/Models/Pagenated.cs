using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Pagenated<T> : List<T>
    {
        public Pagenated(List<T> items, int count, int pageIndex, int pageSize)
        {
            this.AddRange(items);
            PageIndex = pageIndex;
            TotalPage = (int)Math.Ceiling(count / (double)pageSize);
        }

        public int TotalPage { get; set; }
        public int PageIndex { get; set; }
        public bool HasPrev
        {
            get => PageIndex > 1;
        }

        public bool HasNext
        {
            get => PageIndex < TotalPage;
        }

        public static Pagenated<T> Create(IQueryable<T> query, int pageIndex, int pageSize)
        {
            var items = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new Pagenated<T>(items, query.Count(), pageIndex, pageSize);
        }



    }
}
