using ConfitecTeste.Domain.Core.Interfaces.Repositorys;
using ConfitecTeste.Domain.Core.Interfaces.Services;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Domain.Services
{
  public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
            : base(repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        }
        

        
    }
}
