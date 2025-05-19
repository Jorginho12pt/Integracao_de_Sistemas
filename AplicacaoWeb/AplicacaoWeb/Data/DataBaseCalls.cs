using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;

namespace AplicacaoWeb.Data
{
    public class DataBaseCalls
    {
        private readonly IConfiguration _configuration;

        public DataBaseCalls(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Produto> GetProductCallSP()
        {
            try
            {
                List<Produto> produto = new List<Produto>();

                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("GetProduto", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
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
                        connection.Close();
                    }
                }

                return produto;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public List<Testes> GetTestsCallSP()
        {
            try
            {
                List<Testes> testes = new List<Testes>();

                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("GetTestes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Testes body = new Testes();
                            body.IdTeste = Convert.ToInt32(reader["IdTeste"]);
                            body.IdProduto = Convert.ToInt32(reader["IdProduto"]);
                            body.CodigoResultado = Convert.ToInt32(reader["CodigoResultado"]);
                            body.DataTeste = Convert.ToDateTime(reader["DataTeste"]);
                            testes.Add(body);
                        }
                        connection.Close();
                    }
                }

                return testes;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void InsertTesteCallSP([FromBody] TesteRelatorio body)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (var command = new SqlCommand("Insercao", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_DataHora", SqlDbType.DateTime2).Value = body.DataHora;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Int).Value = body.TempoProducao;
                        command.Parameters.Add("@_ResultadoTeste", SqlDbType.Int).Value = body.ResultadoTeste;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

      
        public void UpdateProductCallSP([FromBody] Produto body)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("AtualizacaoProduto", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Int).Value = body.TempoProducao;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }       
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateTestsCallSP([FromBody] Testes body)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("AtualizacaoTestes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdTeste", SqlDbType.Int).Value = body.IdTeste;
                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoResultado", SqlDbType.Int).Value = body.CodigoResultado;
                        command.Parameters.Add("@_DataTeste", SqlDbType.DateTime2).Value = body.DataTeste;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }   
            }
            catch (SqlException ex)
            {
               throw new Exception(ex.ToString());
            }
        }

        public void RemoveProductCallSP([FromBody] Produto body)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("RemocaoProduto", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoPeca", SqlDbType.VarChar).Value = body.CodigoPeca;
                        command.Parameters.Add("@_DataHoraProducao", SqlDbType.DateTime2).Value = body.DataHoraProducao;
                        command.Parameters.Add("@_TempoProducao", SqlDbType.Int).Value = body.TempoProducao;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveTestsCallSP([FromBody] Testes body)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaWeb")))
                {
                    using (SqlCommand command = new SqlCommand("RemocaoTestes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@_IdTeste", SqlDbType.Int).Value = body.IdTeste;
                        command.Parameters.Add("@_IdProduto", SqlDbType.Int).Value = body.IdProduto;
                        command.Parameters.Add("@_CodigoResultado", SqlDbType.Int).Value = body.CodigoResultado;
                        command.Parameters.Add("@_DataTeste", SqlDbType.DateTime2).Value = body.DataTeste;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //--------------------------------------SOAP--------------------------------------------------------
        public string GetCodeProductMaxLosseCall()
        {
            try
            {
                string codigoPeca = "";
                string query = "SELECT TOP 1 [CodigoPeca] FROM [dbo].[CustosPeca] ORDER BY prejuizo DESC";

                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaContabilidade")))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            codigoPeca = result.ToString();
                        }
                    }
                }

                return codigoPeca;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public float GetPeriodTotalCall(int type, int periodo1, int periodo2)
        {
            try
            {
                string typeCall = type switch
                {
                    1 => "CustoProducao",
                    2 => "Lucro",
                    3 => "Prejuizo",
                    _ => throw new ArgumentException("Tipo inválido")
                };

                float resposta = 0;
                
                string query = $@"SELECT {typeCall} FROM [SistemaContabilidade].[dbo].[CustosPeca] WHERE TempoProducao >= @periodo1 AND TempoProducao <= @periodo2";

                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaContabilidade")))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@periodo1", periodo1.ToString());
                        command.Parameters.AddWithValue("@periodo2", periodo2.ToString());

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resposta += float.TryParse(reader[typeCall]?.ToString(), out float result) ? result : 0;
                            }
                        }
                    }
                }

                return resposta;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public CustosPecaFinancial GetProductFinancialCall(string codigoPeca)
        {
            try
            {
                CustosPecaFinancial ?custosPecaFinancial = null;
                string query = "SELECT TOP 1 [CodigoPeca],[CustoProducao],[Lucro],[Prejuizo],[TempoProducao] FROM [SistemaContabilidade].[dbo].[CustosPeca] WHERE CodigoPeca = @codigoPeca";

                using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SistemaContabilidade")))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@codigoPeca", codigoPeca);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                custosPecaFinancial = new CustosPecaFinancial
                                {
                                    CodigoPeca = reader["CodigoPeca"].ToString(),
                                    CustoProducao = reader["CustoProducao"].ToString(),
                                    Lucro = reader["Lucro"].ToString(),
                                    Prejuizo = reader["Prejuizo"].ToString(),
                                    TempoProducao = reader["TempoProducao"].ToString()
                                };
                            }
                        }
                    }
                }

                return custosPecaFinancial;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
