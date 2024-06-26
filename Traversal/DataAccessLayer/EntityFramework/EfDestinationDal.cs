﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> GetLast4Destinations()
        {
            using (var c = new Context())
            {
                var values = c.Destinations.Take(4).OrderByDescending(x => x.DestinationId).ToList();
                return values;
            }
        }

        Destination IDestinationDal.GetDestinationWithGudie(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x => x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
            }
        }
    }
}
