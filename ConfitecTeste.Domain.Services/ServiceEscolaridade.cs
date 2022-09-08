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
    public class ServiceEscolaridade : ServiceBase<Escolaridade>, IServiceEscolaridade
    {
        private readonly IRepositoryEscolaridade repositoryEscolaridade;
        public ServiceEscolaridade(IRepositoryEscolaridade repositoryEscolaridade)
            : base(repositoryEscolaridade)
        {
            this.repositoryEscolaridade = repositoryEscolaridade;
        }
    }
}
