using ConfitecTeste.Application.Dtos;
using ConfitecTeste.Application.Interfaces.Mappers;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Mappers
{
    public class MapperEscolaridade : IMapperEscolaridade
    {
        IEnumerable<EscolaridadeDto> usuarioDtos = new List<EscolaridadeDto>();
        public Escolaridade MapperDtoToEntity(EscolaridadeDto escolaridadeDto)
        {
            var escolaridade = new Escolaridade()
            {
                Id = escolaridadeDto.Id,
                Descricao = escolaridadeDto.Descricao
            };
            return escolaridade;
        }

        public EscolaridadeDto MapperEntityToDto(Escolaridade escolaridade)
        {
            var escolaridadeDto = new EscolaridadeDto()
            {
                Id = escolaridade.Id,
                Descricao = escolaridade.Descricao

            };

            return escolaridadeDto;
        }

        public IEnumerable<EscolaridadeDto> MapperListEscolaridadesDto(IEnumerable<Escolaridade> escolaridades)
        {
            var dto = escolaridades.Select(c => new EscolaridadeDto
            {
                Id = c.Id,
                Descricao = c.Descricao
            });
            return dto;
        }
    }
}
