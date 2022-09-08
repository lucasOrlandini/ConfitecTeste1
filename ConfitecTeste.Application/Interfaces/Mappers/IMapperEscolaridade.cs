using ConfitecTeste.Application.Dtos;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Interfaces.Mappers
{
    interface IMapperEscolaridade
    {
        Escolaridade MapperDtoToEntity(EscolaridadeDto escolaridadeDto);
        IEnumerable<EscolaridadeDto> MapperListEscolaridadesDto(IEnumerable<Escolaridade> escolaridades);
        EscolaridadeDto MapperEntityToDto(Escolaridade escolaridade);
    }
}
