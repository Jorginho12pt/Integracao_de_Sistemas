using AplicacaoWeb.Data;
using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace AplicacaoWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoapApiController : ControllerBase
    {
        private DataBaseCalls _dataBaseCalls;

        private void CheckRafaFunnyBusiness(int periodo1, int periodo2)
        {
            if (periodo1 >= periodo2) throw new ArgumentException("periodo1 tem de ser menor ou igual que periodo2.");
            if (periodo1 <10 || periodo2 >50) throw new ArgumentNullException("periodo1 tem de ser maior que 9 e periodo2 tem de ser menor que 51");
        }

        public SoapApiController(DataBaseCalls dataBaseCalls)
        {
            _dataBaseCalls = dataBaseCalls;
        }

        [HttpGet("GetProductSP")]
        [Produces("application/xml")]
        public ActionResult GetProductSPXML()
        {
            try
            {
                return Ok(_dataBaseCalls.GetProductCallSP());
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetCodeProductMaxLosse")]
        [Produces("application/xml")]
        public ActionResult GetCodeProductMaxLosseSPXML()
        {
            try
            {
                return Ok(_dataBaseCalls.GetCodeProductMaxLosseCall());
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetCostsPeriodTotal")]
        [Produces("application/xml")]
        public ActionResult GetCostsPeriodTotalSPXML(int periodo1, int periodo2)
        {
            try
            {
                CheckRafaFunnyBusiness(periodo1, periodo2);
                return Ok(_dataBaseCalls.GetPeriodTotalCall(1, periodo1, periodo2));
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetProfitsPeriodTotal")]
        [Produces("application/xml")]
        public ActionResult GetProfitsPeriodTotalSPXML(int periodo1, int periodo2)
        {
            try
            {
                CheckRafaFunnyBusiness(periodo1, periodo2);
                return Ok(_dataBaseCalls.GetPeriodTotalCall(2, periodo1, periodo2));
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetLossesPeriodTotal")]
        [Produces("application/xml")]
        public ActionResult GetLossesPeriodTotalSPXML(int periodo1, int periodo2)
        {
            try
            {
                CheckRafaFunnyBusiness(periodo1, periodo2);
                return Ok(_dataBaseCalls.GetPeriodTotalCall(3, periodo1, periodo2));
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetProductFinancial")]
        [Produces("application/xml")]
        public ActionResult GetProductFinancialSPXML(string codeProduct)
        {
            try
            {
                return Ok(_dataBaseCalls.GetProductFinancialCall(codeProduct));
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }
    }    
}
