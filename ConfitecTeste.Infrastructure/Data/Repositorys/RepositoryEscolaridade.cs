using ConfitecTeste.Domain.Core.Interfaces.Repositorys;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Infrastructure.Data.Repositorys
{
    public class RepositoryEscolaridade : RepositoryBase <Escolaridade>, IRepositoryEscolaridade
    {
        private readonly SqlContext sqlContext;

        public RepositoryEscolaridade(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;

        }
    }
}
