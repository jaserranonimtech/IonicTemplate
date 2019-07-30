using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickApp.Pro.ViewModels
{
    public class ListadoPaginadoVM<T>
    {
        public IEnumerable<T> Datos { get; set; }

        public PaginadoVM Paginado { get; set; }
    }

    public class PaginadoVM
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalFiltered { get; internal set; }

        public string sortable { get; set; }
        public string ordenamiento { get; set; }

        public string search { get; set; }
        public string status { get; set; }
        
    }
}
