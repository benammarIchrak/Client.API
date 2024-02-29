using Client.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Business.Interfaces
{
    public interface IClientRepository
    {
        Task<ClientEntity> GetByIdAsync(int id);
    }
}
