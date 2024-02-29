using Client.Business.Entities;
using Client.Business.Interfaces;

namespace Client.Infrastracture.Repositories
{
    public class ClientRepository : IClientRepository
    {
        //private readonly ApplicationDbContext _dbContext;

        //public ClientRepository(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        public async Task<ClientEntity> GetByIdAsync(int id)
        {
            return await GenerateClient(id);
        }

        private async Task<ClientEntity> GenerateClient(int id)
        {
            return new ClientEntity()
            {
                Id = id,
                Name = "test-client",
                Address = "10 rue des fleurs, Paris",
                PhoneNumber = "1234567890",
            };
        }
    }
}
