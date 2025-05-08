using AplicacaoWeb.Models;
using AplicacaoWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace AplicacaoWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private DataBaseCalls _dataBaseCalls;

        public ApiController(IConfiguration configuration, DataBaseCalls dataBaseCalls)
        {
            _configuration = configuration;
            _dataBaseCalls = dataBaseCalls;
        }


        [HttpGet("GetProductSP")]
        public ActionResult GetProductSP()
        {
            try
            {
                return Ok(_dataBaseCalls.GetProductListSP());
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpGet("GetTestsSP")]
        public ActionResult GetTestsSP()
        {
            try
            {
                return Ok(_dataBaseCalls.GetTestsListSP());
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpPost("InsertTesteSP")]
        public ActionResult InsertTesteSP([FromBody] TesteRelatorio body)
        {
            try
            {
                _dataBaseCalls.InsertTesteCallSP(body);

                return Ok("Dados inseridos com sucesso!");
            }
            catch (SqlException ex)
            {               
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpPut("UpdateProductSP")]
        public ActionResult UpdateProductSP([FromBody] Produto body)
        {
            try
            {
                using (SqlConnection SistemaWebConnection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("AtualizacaoProduto", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Int).Value = body.TempoProducao;

                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                        SistemaWebConnection.Close();
                    }
                }

                return Ok("Update efetuado com sucesso!");
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpPut("UpdateTestsSP")]
        public ActionResult UpdateTestsSP([FromBody] Testes body)
        {
            try
            {
                using (SqlConnection SistemaWebConnection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("AtualizacaoTestes", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdTeste", SqlDbType.Int).Value = body.IdTeste;
                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoResultado", SqlDbType.Int).Value = body.CodigoResultado;
                        command.Parameters.Add("@_DataTeste", SqlDbType.DateTime2).Value = body.DataTeste;

                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                        SistemaWebConnection.Close();
                    }
                }

                return Ok("Update efetuado com sucesso!");
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpDelete("RemoveProductSP")]
        public ActionResult RemoveProductSP([FromBody] Produto body)
        {
            try
            {
                using (SqlConnection SistemaWebConnection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("RemocaoProduto", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Int).Value = body.TempoProducao;

                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                        SistemaWebConnection.Close();
                        
                    }
                }

                return Ok("Aluno eliminado com sucesso");
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }

        [HttpDelete("RemoveTestsSP")]
        public ActionResult RemoveTestsSP([FromBody] Testes body)
        {
            try
            {
                using (SqlConnection SistemaWebConnection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("RemocaoTestes", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdTeste", SqlDbType.Int).Value = body.IdTeste;
                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoResultado", SqlDbType.Int).Value = body.CodigoResultado;
                        command.Parameters.Add("@_DataTeste", SqlDbType.DateTime2).Value = body.DataTeste;

                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                        SistemaWebConnection.Close();

                    }
                }

                return Ok("Aluno eliminado com sucesso");
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }
    }
}
