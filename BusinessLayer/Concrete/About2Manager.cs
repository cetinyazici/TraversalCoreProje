﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class About2Manager : IAbout2Service
    {
        IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public List<About2> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(About2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About2 t)
        {
            throw new NotImplementedException();
        }

        public About2 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About2 t)
        {
            throw new NotImplementedException();
        }
    }
}
