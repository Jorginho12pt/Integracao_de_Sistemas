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
                return Ok(_dataBaseCalls.GetProductCallSP());
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
                return Ok(_dataBaseCalls.GetTestsCallSP());
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
                _dataBaseCalls.UpdateProductCallSP(body);

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
                _dataBaseCalls.UpdateTestsCallSP(body);

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
                _dataBaseCalls.RemoveProductCallSP(body);

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
                _dataBaseCalls.RemoveTestsCallSP(body);

                return Ok("Aluno eliminado com sucesso");
            }
            catch (SqlException ex)
            {
                return BadRequest($"Erro no banco de dados: {ex.Message}");
            }
        }
    }
}
