using Client.Business.Entities;
using Client.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Application
{
    public class GetClientByIdUseCase
    {
        private readonly IClientRepository _clientRepository;

        public GetClientByIdUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ClientEntity> ExecuteAsync(int id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }
    }
}
