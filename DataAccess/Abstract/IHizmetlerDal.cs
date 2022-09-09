using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IHizmetlerDal : IEntityRepository<Hizmetler>
    {
        List<HizmetlerDto> GetHizmetlerDetails(
            int? count = null,
            Expression<Func<HizmetlerDto, dynamic>> orderKeySelector = null,
            Expression<Func<HizmetlerDto, bool>> filter = null
        );
        void DeleteDto(HizmetlerDto hizmetlerDto);
    }
}
