﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListbyFilter(x => x.DestinationId == id);
        }
        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetByID(id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
    }
}
