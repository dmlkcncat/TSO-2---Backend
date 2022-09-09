using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IHizmetlerService
    {
        IDataResult<List<Hizmetler>> GetAll();
        IDataResult<Hizmetler> GetById(int hizmetlerId);
        IDataResult<List<HizmetlerDto>> GetHizmetlerDetails(
            int? count,
            Expression<Func<HizmetlerDto, dynamic>> orderKeySelector = null,
            Expression<Func<HizmetlerDto, bool>> filter = null
        );
        IResult DeleteDto(HizmetlerDto hizmetlerDto);
        IResult Add(Hizmetler hizmetler);
        IResult Delete(Hizmetler hizmetler);
        IResult Update(Hizmetler hizmetler);
        IDataResult<List<Hizmetler>> Take(int count, Expression<Func<Hizmetler, dynamic>> orderKeySelector, Expression<Func<Hizmetler, bool>> filter = null);

    }
}
