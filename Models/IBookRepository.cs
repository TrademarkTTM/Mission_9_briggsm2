using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_9_briggsm2.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
