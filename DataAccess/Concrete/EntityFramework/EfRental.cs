using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRental : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> RentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Rental
                             join c in context.Car
                             on r.CarId equals c.CarId
                             join cu in context.Customer
                             on r.CustomerId equals cu.CustomerId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CustomerId=cu.CustomerId,
                                 CarId=c.CarId,
                                 CompanyName=cu.CompanyName,
                                 Description=c.Description
                             };
                return result.ToList();
            }
        }
    }
}
