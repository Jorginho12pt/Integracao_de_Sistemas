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

    //    [HttpGet("GetHighestLossPart")]
    //    [Produces("application/xml")]
    //    public ActionResult GetHighestLossPartSPXML()
    //    {
    //        try
    //        {
    //            List<Produto> produto = new List<Produto>();

               
    //            using (SqlConnection SistemaWebConnection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
    //            {
    //                using (var cmd = new SqlCommand("INSERT INTO dbo.Teste (DataHora, CodigoPeca, TempoProducao, ResultadoTeste) VALUES (@DataHora,@CodigoPeca,@TempoProducao, @ResultadoTeste)"))
    //                {

    //                    cmd.Connection = SistemaWebConnection;

                        

    //                }
    //            }

    //            return Ok(cmd);

    //        }
    //        catch (SqlException ex)
    //        {
    //            return BadRequest($"Erro no banco de dados: {ex.Message}");
    //        }
    //    }

    }    
}
