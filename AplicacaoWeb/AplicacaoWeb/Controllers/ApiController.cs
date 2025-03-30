using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AplicacaoWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        //public SqlConnection SistemaWebConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True");
        //public SqlConnection SistemaContabilidadeConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SistemaContabilidade;Trusted_Connection=True;TrustServerCertificate=True");

        [HttpPost("InsertTesteSP")]
        public ActionResult InsertTesteSP([FromBody] TesteRelatorio body)
        {
            try
            {
                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    using (var command = new SqlCommand("Insercao", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_DataHora", SqlDbType.DateTime2).Value = body.DataHora;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Time).Value = body.TempoProduco;
                        command.Parameters.Add("@_ResultadoTeste", SqlDbType.Int).Value = body.ResultadoTeste;

                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                        SistemaWebConnection.Close();
                    }
                }

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
                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand command = new SqlCommand("AtualizacaoProduto", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Time).Value = body.TempoProduco;

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
                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
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
                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand command = new SqlCommand("RemocaoProduto", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Time).Value = body.TempoProduco;

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
                using (SqlConnection SistemaWebConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaWeb;Trusted_Connection=True;TrustServerCertificate=True"))
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
