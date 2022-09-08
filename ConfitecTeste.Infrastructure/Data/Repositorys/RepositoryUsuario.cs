using ConfitecTeste.Domain.Core.Interfaces.Repositorys;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Infrastructure.Data.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly SqlContext sqlContext;

        public RepositoryUsuario(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;

        }
    }
}
