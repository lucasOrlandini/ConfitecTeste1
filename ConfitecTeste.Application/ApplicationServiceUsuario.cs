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
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IServiceUsuario serviceUsuario;
        private readonly IMapperUsuario mapperUsuario;
        public ApplicationServiceUsuario(
            IServiceUsuario serviceUsuario,
            IMapperUsuario mapperUsuario)
        {
            this.serviceUsuario = serviceUsuario;
            this.mapperUsuario = mapperUsuario;
        }
        public void Add(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Add(usuario);
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            var usuarios = serviceUsuario.GetAll();
            return mapperUsuario.MapperListUsuariosDto(usuarios);
        }

        public UsuarioDto GetById(int id)
        {
            var usuario = serviceUsuario.GetById(id);
            return mapperUsuario.MapperEntityToDto(usuario);
        }

        public void Remove(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Remove(usuario);
        }

        public void Update(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Update(usuario);
        }
    }
}
