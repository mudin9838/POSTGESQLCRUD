using POSTGESQLCRUD.DAL.Data;

namespace POSTGESQLCRUD.BLL.Services.Contracts
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task AddAsync(Department entity);
        Task UpdateAsync(Department entity);
        Task DeleteAsync(Department entity);

        Task<Department> GetByIdAsync(string id);

    }
}
