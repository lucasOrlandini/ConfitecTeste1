using ConfitecTeste.Application.Dtos;
using ConfitecTeste.Application.Interfaces;
using ConfitecTeste.Application.Interfaces.Mappers;
using ConfitecTeste.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application
{
    public class ApplicationServiceEscolaridade : IApplicationServiceEscolaridade
    {
        private readonly IServiceEscolaridade serviceEscolaridade;
        private readonly IMapperEscolaridade mapperEscolaridade;

        //public ApplicationServiceEscolaridade(
        //   IServiceUsuario serviceUsuario,
        //   IMapperUsuario mapperUsuario)
        //{
        //    this.serviceEscolaridade = serviceEscolaridade;
        //    this.mapperEscolaridade = mapperEscolaridade;
        //}
        public void Add(EscolaridadeDto escolaridadeDto)
        {
            var escolaridade = mapperEscolaridade.MapperDtoToEntity(escolaridadeDto);
            serviceEscolaridade.Add(escolaridade);
        }

        public IEnumerable<EscolaridadeDto> GetAll()
        {
            var escolaridades = serviceEscolaridade.GetAll();
            return mapperEscolaridade.MapperListEscolaridadesDto(escolaridades);
        }

        public EscolaridadeDto GetById(int id)
        {
            var escolaridade = serviceEscolaridade.GetById(id);
            return mapperEscolaridade.MapperEntityToDto(escolaridade);
        }

        public void Remove(EscolaridadeDto escolaridadeDto)
        {
            var escolaridade = mapperEscolaridade.MapperDtoToEntity(escolaridadeDto);
            serviceEscolaridade.Remove(escolaridade);
        }

        public void Update(EscolaridadeDto escolaridadeDto)
        {
            var escolaridade = mapperEscolaridade.MapperDtoToEntity(escolaridadeDto);
            serviceEscolaridade.Update(escolaridade);
        }
    }
}
