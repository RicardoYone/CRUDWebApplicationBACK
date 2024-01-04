using Microsoft.EntityFrameworkCore;
using CRUDWebApplicationBACK.Models;
using CRUDWebApplicationBACK.Services.Contrato;

namespace CRUDWebApplicationBACK.Services.Implementacion
{
    public class DepartamentoService:IDepartamentoService
    {
        private DbempleadoContext _dbContext;

        public DepartamentoService(DbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>> GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Departamentos.ToListAsync();

                return lista;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
