using POSTGESQLCRUD.DAL.Data;
using POSTGESQLCRUD.DAL.Repositories.Contracts;

namespace POSTGESQLCRUD.BLL.Services.Contracts
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IGenericRepository<Department> _repository;

        public DepartmentService(IGenericRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Department entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(Department entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Department> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Department entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
