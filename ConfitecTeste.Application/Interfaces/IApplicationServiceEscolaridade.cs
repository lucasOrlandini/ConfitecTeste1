using ConfitecTeste.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Interfaces
{
   public interface IApplicationServiceEscolaridade
    {
        void Add(EscolaridadeDto escolaridadeDto);
        void Update(EscolaridadeDto escolaridadeDto);
        void Remove(EscolaridadeDto escolaridadeDto);
        IEnumerable<EscolaridadeDto> GetAll();
        EscolaridadeDto GetById(int id);
    }
}
