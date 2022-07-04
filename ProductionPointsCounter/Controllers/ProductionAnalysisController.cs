using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductionPointsCounterAPI.Entities;
using ProductionPointsCounterAPI.Models;

namespace ProductionPointsCounterAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductionAnalysisController : ControllerBase
    {
        private readonly Sandbox_01Context _dbContext;


        public ProductionAnalysisController(Sandbox_01Context dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public ActionResult<IEnumerable<OrdersDto>> Get()
        {

            var sampleData = _dbContext.Oferties
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
                .Take(100)
                .AsNoTracking()
                .ToList();
            return Ok(sampleData);
        }

    }
}
