using AplicacaoWeb.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AplicacaoWeb.API
{
    public class WebAPI : ControllerBase
    {


        public SqlConnection SistemaWebConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SistemaDesktop;Integrated Security=True");
        public SqlConnection SistemaContabilidadeConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SistemaContabilidade;Integrated Security=True");

        [HttpPost]
        public ActionResult Post([FromBody] TesteRelatorio body)
        {
            try
            {
                using (SistemaWebConnection)
                {
                    using (var command = new SqlCommand("Insercao", SistemaWebConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_DataHora", SqlDbType.VarChar).Value = body.DataHora;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.VarChar).Value = body.TempoProduco;
                        command.Parameters.Add("@_ResultadoTeste", SqlDbType.VarChar).Value = body.ResultadoTeste;
                        SistemaWebConnection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                return Ok("Data inserted successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return BadRequest("Error inserting data");
            }
        }
    }
}
