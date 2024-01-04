using CRUDWebApplicationBACK.Models;

namespace CRUDWebApplicationBACK.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
