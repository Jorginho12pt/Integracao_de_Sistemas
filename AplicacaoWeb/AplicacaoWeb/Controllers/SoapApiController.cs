using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AplicacaoWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoapApiController : ControllerBase
    {

        [HttpGet("GetProductSP")]
        [Produces("application/xml")]
        public ActionResult GetProductSPXML()
        {
            try
            {
                List<Produto> produto = new List<Produto>();

                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand command = new SqlCommand("GetProduto", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SistemaWebConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Produto body = new Produto();
                            body.IdProduto = Convert.ToInt32(reader["IdProduto"]);
                            body.CodigoPeca = Convert.ToString(reader["CodigoPeca"]);
                            body.DataHoraProducao = Convert.ToDateTime(reader["DataHoraProducao"]);
                            body.TempoProducao = Convert.ToInt32(reader["TempoProducao"]);
                            produto.Add(body);
                        }
                        SistemaWebConnection.Close();
                    }
                }

                return Ok(produto);
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }





    }
}
