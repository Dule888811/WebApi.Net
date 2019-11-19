
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiApiTest.Repository
{
    public class BaseRepository
    {
        protected readonly skolaEntities context;

        public BaseRepository(skolaEntities context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}