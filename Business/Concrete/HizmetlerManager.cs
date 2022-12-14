using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class HizmetlerManager : IHizmetlerService
    {

        IHizmetlerDal _hizmetlerDal;
        public HizmetlerManager(IHizmetlerDal hizmetlerDal)
        {
            _hizmetlerDal = hizmetlerDal;
        }

        public IResult Add(Hizmetler hizmetler)
        {
            _hizmetlerDal.Add(hizmetler);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Hizmetler hizmetler)
        {
            _hizmetlerDal.Delete(hizmetler);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(HizmetlerDto hizmetlerDto)
        {
            _hizmetlerDal.DeleteDto(hizmetlerDto);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Hizmetler>> Take(int count, Expression<Func<Hizmetler, dynamic>> orderKeySelector, Expression<Func<Hizmetler, bool>> filter = null)
        {
            return new SuccessDataResult<List<Hizmetler>>(_hizmetlerDal.Take(count, orderKeySelector, filter), Messages.Listed);
        }

        public IDataResult<List<Hizmetler>> GetAll()
        {
            return new SuccessDataResult<List<Hizmetler>>(_hizmetlerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Hizmetler> GetById(int hizmetlerId)
        {
            return new SuccessDataResult<Hizmetler>(_hizmetlerDal.Get(p => p.Id == hizmetlerId));
        }

        public IDataResult<List<HizmetlerDto>> GetHizmetlerDetails(
            int? count = null,
            Expression<Func<HizmetlerDto, dynamic>> orderKeySelector = null,
            Expression<Func<HizmetlerDto, bool>> filter = null
        )
        {
            return new SuccessDataResult<List<HizmetlerDto>>(
                _hizmetlerDal.GetHizmetlerDetails(count, orderKeySelector, filter),
                Messages.Listed
            );
        }

        public IResult Update(Hizmetler hizmetler)
        {
            _hizmetlerDal.Update(hizmetler);
            return new SuccessResult(Messages.Updated);
        }
    }
}
