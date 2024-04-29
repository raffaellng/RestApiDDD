using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;

namespace RestApiModeloDDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceClientes _applicationServiceClientes;

        public ClienteController(IApplicationServiceClientes applicationServiceClientes)
        {
            _applicationServiceClientes = applicationServiceClientes;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClientes.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetId(int id)
        {
            return Ok(_applicationServiceClientes.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceClientes.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceClientes.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceClientes.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}