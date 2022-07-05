using Microsoft.EntityFrameworkCore;
using ProductionPointsCounterAPI.Entities;
using ProductionPointsCounterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionPointsCounterAPI.Services
{
    public interface IProductionAnalysisService
    {
        IEnumerable<OrdersDto> GetOrders(int amountOfOrders);
        IEnumerable<OrdersDto> GetToday();
    }

    public class ProductionAnalysisService : IProductionAnalysisService
    {


        private readonly DataBaseContext _dbContext;

        public ProductionAnalysisService(DataBaseContext dbContext)
        {
            _dbContext = dbContext;

        }
        public IEnumerable<OrdersDto> GetOrders(int amountOfOrders)
        {
            var ordersDtos = _dbContext.Oferties
                .Where(x => x.ZlecenieT != "")
                .Select(x => new OrdersDto()
                {
                    OrderName = x.ZlecenieT,
                    Status = x.Stan,
                    Id = x.Indeks,
                    ProductionDate = x.Realizacja,
                    ProductionPoints = x.IlJedn
                })
                .OrderByDescending(x => x.ProductionDate)
                .Take(amountOfOrders)
                .AsNoTracking()
                .ToList();
            return ordersDtos;
        }
        
        public IEnumerable<OrdersDto> GetToday()
        {
            var timeNow = new DateTime();
            timeNow = DateTime.Now.Date;
            var ordersDtos = _dbContext.Oferties
                .Where(x => x.ZlecenieT != "" && x.Realizacja == timeNow && x.Stan != "Odrzucone")
                .Select(x => new OrdersDto()
                {
                    OrderName = x.ZlecenieT,
                    Status = x.Stan,
                    Id = x.Indeks,
                    ProductionDate = x.Realizacja,
                    ProductionPoints = x.IlJedn
                })
                .OrderByDescending(x => x.ProductionDate)
                .Take(100)
                .AsNoTracking()
                .ToList();
            return ordersDtos;
        }
    }
}
