using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductionPointsCounterAPI.Entities;
using ProductionPointsCounterAPI.Models;
using ProductionPointsCounterAPI.Services;

namespace ProductionPointsCounterAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductionAnalysisController : ControllerBase
    {

        private readonly IProductionAnalysisService _productionAnalysisService;

        public ProductionAnalysisController(IProductionAnalysisService productionAnalysisService)
        {
            
            _productionAnalysisService = productionAnalysisService;
        }

        [HttpGet("orders/{amountOfOrders}")]
        public ActionResult<IEnumerable<OrdersDto>> GetOrders([FromRoute]int amountOfOrders)
        {

            var ordersDtos = _productionAnalysisService.GetOrders(amountOfOrders);
            return Ok(ordersDtos);
        }
        [HttpGet]
        [Route("today")]
        public ActionResult<IEnumerable<OrdersDto>> GetToday()
        {

            var ordersDtos = _productionAnalysisService.GetToday();
            return Ok(ordersDtos);
        }
        [HttpGet]
        [Route("desktop")]
        public ActionResult<ProductionDesktopDto> GetDesktop()
        {

            var ordersDtos = _productionAnalysisService.GetDesktop();
            return Ok(ordersDtos);
        }
    }
}
