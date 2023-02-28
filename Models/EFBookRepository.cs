﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_9_briggsm2.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
